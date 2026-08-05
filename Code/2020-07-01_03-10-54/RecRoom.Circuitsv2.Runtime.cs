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
	[Cpp2IlInjected.Address(RVA = "0x14715F0", Offset = "0x146FFF0", VA = "0x1814715F0")]
	public static Guid ToGuid(this ByteString bytes)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1471430", Offset = "0x146FE30", VA = "0x181471430")]
	public static ByteString ToByteString(this Guid guid)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1471780", Offset = "0x1470180", VA = "0x181471780")]
	public static Guid? ToGuid(this NullableBytes bytes)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1471520", Offset = "0x146FF20", VA = "0x181471520")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E2CEB0", Offset = "0x2E2B8B0", VA = "0x182E2CEB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x242B690", Offset = "0x242A090", VA = "0x18242B690")]
		public RateLimitedSynchronizedField(SynchronizedField<T> internalField, T initialValue, RateLimiter rateLimiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xEC99E0", Offset = "0xEC83E0", VA = "0x180EC99E0")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x242B450", Offset = "0x2429E50", VA = "0x18242B450")]
		public bool Set(T newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x242B180", Offset = "0x2429B80", VA = "0x18242B180", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x242BB20", Offset = "0x242A520", VA = "0x18242BB20")]
		public bool HasReferences(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x242BD90", Offset = "0x242A790", VA = "0x18242BD90")]
		public bool TryGetRefCount(TKey key, out int refCount)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x242BBB0", Offset = "0x242A5B0", VA = "0x18242BBB0")]
		public void IncrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x242B930", Offset = "0x242A330", VA = "0x18242B930")]
		public void DecrementRefCount(TKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xEC16E0", Offset = "0xEC00E0", VA = "0x180EC16E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15EE420", Offset = "0x15ECE20", VA = "0x1815EE420")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x15EE4C0", Offset = "0x15ECEC0", VA = "0x1815EE4C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x15EE2E0", Offset = "0x15ECCE0", VA = "0x1815EE2E0")]
		private ShortenedGuidMap(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x15ED9C0", Offset = "0x15EC3C0", VA = "0x1815ED9C0")]
		public static ShortenedGuidMap FromRequiredCharacters(int requiredCharacters, IGuidShortenerMethod guidShortenerMethod)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x15EDB20", Offset = "0x15EC520", VA = "0x1815EDB20")]
		public string GetShortened(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x15EDC00", Offset = "0x15EC600", VA = "0x1815EDC00")]
		private string GuidToShortenedString(Guid guid, int requiredCharacters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x15EDFB0", Offset = "0x15EC9B0", VA = "0x1815EDFB0")]
		private string RemapGuid(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x15EDCE0", Offset = "0x15EC6E0", VA = "0x1815EDCE0")]
		private void RemapExisting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x15EE240", Offset = "0x15ECC40", VA = "0x1815EE240")]
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
			[Cpp2IlInjected.Address(RVA = "0x15DC4D0", Offset = "0x15DAED0", VA = "0x1815DC4D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		private Base64GuidShortenerMethod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x15DC3C0", Offset = "0x15DADC0", VA = "0x1815DC3C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x15ECB00", Offset = "0x15EB500", VA = "0x1815ECB00")]
		public static bool IsEmpty(this CircuitContextData contextData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x11F7380", Offset = "0x11F5D80", VA = "0x1811F7380")]
		private static bool IsRepeatedFieldEmpty<T>(RepeatedField<T> repeatedField)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x15ECE20", Offset = "0x15EB820", VA = "0x1815ECE20")]
		internal static Vector3 ToVector3(this Vector3Data vector3Data)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x15ECD70", Offset = "0x15EB770", VA = "0x1815ECD70")]
		internal static Vector3Data ToVector3Data(this Vector3 vector3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x15ECC70", Offset = "0x15EB670", VA = "0x1815ECC70")]
		internal static Quaternion ToQuaternion(this QuaternionData quaternionData)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x15ECBC0", Offset = "0x15EB5C0", VA = "0x1815ECBC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x627440", Offset = "0x625E40", VA = "0x180627440")]
			[DebuggerHidden]
			public <DFS>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x15EF530", Offset = "0x15EDF30", VA = "0x1815EF530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15EFD00", Offset = "0x15EE700", VA = "0x1815EFD00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x15EFC60", Offset = "0x15EE660", VA = "0x1815EFC60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x15EFC60", Offset = "0x15EE660", VA = "0x1815EFC60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x15EB5C0", Offset = "0x15E9FC0", VA = "0x1815EB5C0")]
		[IteratorStateMachine(typeof(<DFS>d__1))]
		public static IEnumerable<Node> DFS(Node root, DFSType dfsType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x15EB640", Offset = "0x15EA040", VA = "0x1815EB640")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FA60", Offset = "0x38E460", VA = "0x18038FA60")]
			public NotRestriction(params Type[] notTypes)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x15EC3A0", Offset = "0x15EADA0", VA = "0x1815EC3A0")]
			protected bool Equals(NotRestriction other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x15EC3E0", Offset = "0x15EADE0", VA = "0x1815EC3E0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x10984D0", Offset = "0x1096ED0", VA = "0x1810984D0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1289950", Offset = "0x1288350", VA = "0x181289950")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AFB20", Offset = "0x3AE520", VA = "0x1803AFB20")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1475480", Offset = "0x1473E80", VA = "0x181475480")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[NotNull]
		public Dependencies RecRoomDependencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3972C0", Offset = "0x395CC0", VA = "0x1803972C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1475160", Offset = "0x1473B60", VA = "0x181475160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CircuitContext Parent
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3D4EA0", Offset = "0x3D38A0", VA = "0x1803D4EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3D4060", Offset = "0x3D2A60", VA = "0x1803D4060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CircuitContextNode ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x413C10", Offset = "0x412610", VA = "0x180413C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x470D60", Offset = "0x46F760", VA = "0x180470D60")]
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
			[Cpp2IlInjected.Address(RVA = "0x14751B0", Offset = "0x1473BB0", VA = "0x1814751B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IsDisposed
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4B9D10", Offset = "0x4B8710", VA = "0x1804B9D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<CircuitContext, Node> OnCircuitNodeAdded
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1474EE0", Offset = "0x14738E0", VA = "0x181474EE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x1475200", Offset = "0x1473C00", VA = "0x181475200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1474F80", Offset = "0x1473980", VA = "0x181474F80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x14752A0", Offset = "0x1473CA0", VA = "0x1814752A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<NodeConnection> OnNodesConnected
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1475020", Offset = "0x1473A20", VA = "0x181475020")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1475340", Offset = "0x1473D40", VA = "0x181475340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NodeConnection> OnNodesDisconnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x14750C0", Offset = "0x1473AC0", VA = "0x1814750C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x14753E0", Offset = "0x1473DE0", VA = "0x1814753E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1474CF0", Offset = "0x14736F0", VA = "0x181474CF0")]
		protected CircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x14729B0", Offset = "0x14713B0", VA = "0x1814729B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "7")]
		protected virtual void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1471AC0", Offset = "0x14704C0", VA = "0x181471AC0")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x14732F0", Offset = "0x1471CF0", VA = "0x1814732F0")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1471830", Offset = "0x1470230", VA = "0x181471830")]
		protected void AddChildContext(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1473D60", Offset = "0x1472760", VA = "0x181473D60")]
		public bool SendEvent(CircuitEvent circuitEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1473D90", Offset = "0x1472790", VA = "0x181473D90")]
		public void SendSynchronizedEvent(CircuitEvent circuitEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x14736D0", Offset = "0x14720D0", VA = "0x1814736D0")]
		public void RequestCreateNewCircuitNode(Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1473AA0", Offset = "0x14724A0", VA = "0x181473AA0")]
		public void RequestDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x14738E0", Offset = "0x14722E0", VA = "0x1814738E0")]
		public void RequestCreateNewDynamicEvent(string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1473B90", Offset = "0x1472590", VA = "0x181473B90")]
		public void RequestDestroyDynamicEvent(Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1473170", Offset = "0x1471B70", VA = "0x181473170")]
		public void LocalDestroyCircuitNode(Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1473140", Offset = "0x1471B40", VA = "0x181473140")]
		public void LocalDestroyCircuitNode([NotNull] Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x14718D0", Offset = "0x14702D0", VA = "0x1814718D0")]
		public void AddCircuitNode(Node circuitNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x14744B0", Offset = "0x1472EB0", VA = "0x1814744B0")]
		protected bool TryFindNodeViaGloballyUniqueIdInternal(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1473E00", Offset = "0x1472800", VA = "0x181473E00", Slot = "9")]
		public virtual CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x14722F0", Offset = "0x1470CF0", VA = "0x1814722F0")]
		internal void DeserializeTemplateData(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1472E20", Offset = "0x1471820", VA = "0x181472E20")]
		internal void InferAllNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1471D00", Offset = "0x1470700", VA = "0x181471D00", Slot = "10")]
		public virtual void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x11EB290", Offset = "0x11E9C90", VA = "0x1811EB290")]
		public bool TryFindNode<TNode>(Guid nodeId, out TNode node) where TNode : Node
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1474840", Offset = "0x1473240", VA = "0x181474840")]
		public bool TryFindNode(Guid nodeId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1474440", Offset = "0x1472E40", VA = "0x181474440")]
		public bool TryFindChildContext(Guid childContextId, out CircuitContext childContext)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x14735B0", Offset = "0x1471FB0", VA = "0x1814735B0")]
		public void RaiseOnCircuitNodesConnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1473640", Offset = "0x1472040", VA = "0x181473640")]
		public void RaiseOnCircuitNodesDisconnected(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1471A60", Offset = "0x1470460", VA = "0x181471A60")]
		public void AddNodeRestriction(INodeRestriction nodeRestriction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1473110", Offset = "0x1471B10", VA = "0x181473110")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A8090", Offset = "0x3A6A90", VA = "0x1803A8090")]
			public EventRegistration(CircuitContext registeredToContext, CircuitEventDefinition eventDefinition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x147D150", Offset = "0x147BB50", VA = "0x18147D150")]
			public void AddCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x147D270", Offset = "0x147BC70", VA = "0x18147D270")]
			public void RemoveCircuitEventHandler(ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x147D3B0", Offset = "0x147BDB0", VA = "0x18147D3B0", Slot = "5")]
			public EventRegistrationData SerializeToProtobuf()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x1AA8640", Offset = "0x1AA7040", VA = "0x181AA8640", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1030230", Offset = "0x102EC30", VA = "0x181030230")]
			protected LimitedEventQueueBase(int maxEventsToProcessPerFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1AA8580", Offset = "0x1AA6F80", VA = "0x181AA8580")]
			public bool PushEvent(T queueEntry)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1AA8420", Offset = "0x1AA6E20", VA = "0x181AA8420", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1487920", Offset = "0x1486320", VA = "0x181487920")]
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
				[Cpp2IlInjected.Address(RVA = "0x18F690", Offset = "0x18EA90", VA = "0x18018F690")]
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
				[Cpp2IlInjected.Address(RVA = "0x1484EB0", Offset = "0x14838B0", VA = "0x181484EB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			protected override Queue<CircuitEvent> CurrentInsertQueue
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x1484EC0", Offset = "0x14838C0", VA = "0x181484EC0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1484D40", Offset = "0x1483740", VA = "0x181484D40")]
			public LocalEventQueue(ITimeProvider timeProvider, int maxEventsToProcessPerFrame = 1024)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1484BB0", Offset = "0x14835B0", VA = "0x181484BB0")]
			public bool PushEventDelayed(CircuitEvent circuitEvent, float delay)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x14849E0", Offset = "0x14833E0", VA = "0x1814849E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x147CA60", Offset = "0x147B460", VA = "0x18147CA60")]
			public void AddCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x147CF40", Offset = "0x147B940", VA = "0x18147CF40")]
			public void RemoveCircuitEventHandler(CircuitEventDefinition eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x147D060", Offset = "0x147BA60", VA = "0x18147D060")]
			private void RemoveHandlerInternal(Guid eventType, ICircuitEventHandler handler)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x147CBC0", Offset = "0x147B5C0", VA = "0x18147CBC0")]
			public void HandleEvent(CircuitEvent circuitEvent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x147CB60", Offset = "0x147B560", VA = "0x18147CB60")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x147D0D0", Offset = "0x147BAD0", VA = "0x18147D0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1477A10", Offset = "0x1476410", VA = "0x181477A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x14776B0", Offset = "0x14760B0", VA = "0x1814776B0")]
		public CircuitEventBus(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1476D40", Offset = "0x1475740", VA = "0x181476D40")]
		public EventRegistration RegisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1477120", Offset = "0x1475B20", VA = "0x181477120")]
		public EventRegistration RegisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1476E20", Offset = "0x1475820", VA = "0x181476E20")]
		private EventRegistration RegisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1477610", Offset = "0x1476010", VA = "0x181477610")]
		public void UnregisterDynamicCircuitEvent(Guid circuitEventDefinitionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x14776A0", Offset = "0x14760A0", VA = "0x1814776A0")]
		public void UnregisterDynamicCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1477410", Offset = "0x1475E10", VA = "0x181477410")]
		public void UnregisterBuiltInCircuitEvent(CircuitEventDefinition circuitEventDefinition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1477420", Offset = "0x1475E20", VA = "0x181477420")]
		private void UnregisterCircuitEvent(CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1476490", Offset = "0x1474E90", VA = "0x181476490")]
		public IEnumerable<EventRegistration> GetListenableEvents(bool onlyPlayerListenable = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1475DB0", Offset = "0x14747B0", VA = "0x181475DB0")]
		private IReadOnlyList<EventRegistration> GetAllListenableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x14761D0", Offset = "0x1474BD0", VA = "0x1814761D0")]
		public EventRegistration GetListenableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1476590", Offset = "0x1474F90", VA = "0x181476590")]
		public EventRegistration GetSendableEventRegistration(Guid contextId, Guid eventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1476660", Offset = "0x1475060", VA = "0x181476660")]
		public IReadOnlyList<EventRegistration> GetSendableEvents()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1476D10", Offset = "0x1475710", VA = "0x181476D10")]
		public bool Publish(CircuitEvent outgoingEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1476AF0", Offset = "0x14754F0", VA = "0x181476AF0")]
		public bool PublishDelayed(CircuitEvent outgoingEvent, float delay)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1476C90", Offset = "0x1475690", VA = "0x181476C90")]
		public bool PublishSynced(CircuitEvent outgoingEvent, SynchronizedCircuitContext.SyncedEventTargets syncedEventTarget)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1476A10", Offset = "0x1475410", VA = "0x181476A10")]
		public void ProcessEventQueues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x14768D0", Offset = "0x14752D0", VA = "0x1814768D0")]
		private void HandleLocalEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1477170", Offset = "0x1475B70", VA = "0x181477170")]
		private void SendSyncedEvent(Tuple<CircuitEvent, SynchronizedCircuitContext.SyncedEventTargets> circuitEventAndTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x14768F0", Offset = "0x14752F0", VA = "0x1814768F0")]
		public void HandleReceivedSyncedEvent(SynchronizedEventData syncedEventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1475680", Offset = "0x1474080", VA = "0x181475680")]
		public void ClearListenableEventsCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1477230", Offset = "0x1475C30", VA = "0x181477230", Slot = "6")]
		public EventBusData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1475B10", Offset = "0x1474510", VA = "0x181475B10")]
		public void DeserializeFromTemplate(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1475910", Offset = "0x1474310", VA = "0x181475910", Slot = "4")]
		public void DeserializeFromProtobuf(EventBusData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1475CE0", Offset = "0x14746E0", VA = "0x181475CE0")]
		private void DestroyCircuitObjectFromProtoData(CircuitEventObject circuitEventObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x14756F0", Offset = "0x14740F0", VA = "0x1814756F0")]
		private CircuitEventObject CreateCircuitObjectFromProtoData(Guid eventId, CircuitEventObjectData protobufdata)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1475D10", Offset = "0x1474710", VA = "0x181475D10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x14773A0", Offset = "0x1475DA0", VA = "0x1814773A0")]
		public bool TryGetDynamicEventObject(Guid eventDefEventDefinitionId, out CircuitEventObject circuitEventObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x14769B0", Offset = "0x14753B0", VA = "0x1814769B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1479F10", Offset = "0x1478910", VA = "0x181479F10")]
		public CircuitEvent(Guid circuitEventTypeGuid, CircuitEventDefinition eventDefinition, IReadOnlyDictionary<string, CircuitSignal> signals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x14795C0", Offset = "0x1477FC0", VA = "0x1814795C0")]
		public SynchronizedEventData Pack()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1479AC0", Offset = "0x14784C0", VA = "0x181479AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x147C9B0", Offset = "0x147B3B0", VA = "0x18147C9B0")]
			public EventBuilder(CircuitEventDefinition definition)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x147C910", Offset = "0x147B310", VA = "0x18147C910")]
			public EventBuilder WithSignal(string signalName, CircuitSignal signal)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x147C810", Offset = "0x147B210", VA = "0x18147C810")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x1478490", Offset = "0x1476E90", VA = "0x181478490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, CircuitType> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OnDefinitionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1478350", Offset = "0x1476D50", VA = "0x181478350")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x14783F0", Offset = "0x1476DF0", VA = "0x1814783F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1478290", Offset = "0x1476C90", VA = "0x181478290")]
		public CircuitEventDefinition(string name, Guid eventDefinitionId, bool isPlayerListenable = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1477E20", Offset = "0x1476820", VA = "0x181477E20")]
		private bool Equals(CircuitEventDefinition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1477D20", Offset = "0x1476720", VA = "0x181477D20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1477E60", Offset = "0x1476860", VA = "0x181477E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x956270", Offset = "0x954C70", VA = "0x180956270")]
		public static bool operator !=(CircuitEventDefinition left, CircuitEventDefinition right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1477A60", Offset = "0x1476460", VA = "0x181477A60")]
		[EditableAddNamedPort(null)]
		public CircuitEventDefinition AddEventPropertyLocal(string name, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1477F50", Offset = "0x1476950", VA = "0x181477F50")]
		public CircuitEventDefinition RemoveEventPropertyLocal(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1477FF0", Offset = "0x14769F0", VA = "0x181477FF0", Slot = "5")]
		public CircuitEventDefinitionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1477B00", Offset = "0x1476500", VA = "0x181477B00", Slot = "4")]
		public void DeserializeFromProtobuf(CircuitEventDefinitionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1477E80", Offset = "0x1476880", VA = "0x181477E80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1479410", Offset = "0x1477E10", VA = "0x181479410")]
		public CircuitEventObject(CircuitContext context, CircuitEventDefinition definition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1478CC0", Offset = "0x14776C0", VA = "0x181478CC0")]
		private bool Equals(CircuitEventObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1478D00", Offset = "0x1477700", VA = "0x181478D00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1478E10", Offset = "0x1477810", VA = "0x181478E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1478E40", Offset = "0x1477840", VA = "0x181478E40")]
		public void RequestAddEventProperty(string name, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1478FB0", Offset = "0x14779B0", VA = "0x181478FB0")]
		public void RequestRemoveEventProperty(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x14790E0", Offset = "0x1477AE0", VA = "0x1814790E0", Slot = "10")]
		public override CircuitEventObjectData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1478930", Offset = "0x1477330", VA = "0x181478930", Slot = "11")]
		public override void DeserializeFromProtobuf(CircuitEventObjectData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x14793C0", Offset = "0x1477DC0", VA = "0x1814793C0", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1478840", Offset = "0x1477240", VA = "0x181478840", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x1478830", Offset = "0x1477230", VA = "0x181478830")]
		public CircuitEventObjectModificationHandler(CircuitEventObject modifiedEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x14784D0", Offset = "0x1476ED0", VA = "0x1814784D0")]
		public ICircuitObjectModification CreateAddPropertyModification(string propertyName, CircuitType circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x14785A0", Offset = "0x1476FA0", VA = "0x1814785A0")]
		public ICircuitObjectModification CreateRemovePropertyModification(string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1478640", Offset = "0x1477040", VA = "0x181478640", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x1481600", Offset = "0x1480000", VA = "0x181481600")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public RateLimiter GlobalSyncedEventRateLimiter
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x3E16F0", Offset = "0x3E00F0", VA = "0x1803E16F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1481590", Offset = "0x147FF90", VA = "0x181481590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int BufferedOperationsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x1481540", Offset = "0x147FF40", VA = "0x181481540")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x1481B20", Offset = "0x1480520", VA = "0x181481B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ObjectCircuitContext> OnObjectCircuitContextCreated
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x14814A0", Offset = "0x147FEA0", VA = "0x1814814A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1481A80", Offset = "0x1480480", VA = "0x181481A80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<CircuitContext, Node> OnCircuitNodeAddedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1481180", Offset = "0x147FB80", VA = "0x181481180")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1481760", Offset = "0x1480160", VA = "0x181481760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CircuitContext, Node> OnCircuitNodeDestroyedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1481220", Offset = "0x147FC20", VA = "0x181481220")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1481800", Offset = "0x1480200", VA = "0x181481800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<NodeConnection> OnNodesConnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1481360", Offset = "0x147FD60", VA = "0x181481360")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x1481940", Offset = "0x1480340", VA = "0x181481940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<NodeConnection> OnNodesDisconnectedGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x1481400", Offset = "0x147FE00", VA = "0x181481400")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x14819E0", Offset = "0x14803E0", VA = "0x1814819E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<CircuitContext, CircuitContext> OnContextChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x14812C0", Offset = "0x147FCC0", VA = "0x1814812C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x14818A0", Offset = "0x14802A0", VA = "0x1814818A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventRegisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1481040", Offset = "0x147FA40", VA = "0x181481040")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1481620", Offset = "0x1480020", VA = "0x181481620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action<CircuitContext, CircuitEventDefinition, bool> OnCircuitEventUnregisteredGlobal
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x14810E0", Offset = "0x147FAE0", VA = "0x1814810E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x14816C0", Offset = "0x14800C0", VA = "0x1814816C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x147ED70", Offset = "0x147D770", VA = "0x18147ED70")]
		public Guid NextGuid()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1480CE0", Offset = "0x147F6E0", VA = "0x181480CE0")]
		public GlobalCircuitContext(ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1480D80", Offset = "0x147F780", VA = "0x181480D80")]
		public GlobalCircuitContext(Guid contextId, ICircuitContextNetworking circuitContextNetworking, Dependencies recRoomDependencies)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4BDC60", Offset = "0x4BC660", VA = "0x1804BDC60")]
		public void ResetMaxExecutions(int newRemaining = 1000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x147D770", Offset = "0x147C170", VA = "0x18147D770", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextId, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1480BE0", Offset = "0x147F5E0", VA = "0x181480BE0")]
		public bool TryFindNodeViaGloballyUniqueId(Guid globallyUniqueId, out Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1480B90", Offset = "0x147F590", VA = "0x181480B90", Slot = "9")]
		public sealed override CircuitContextData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x147D8C0", Offset = "0x147C2C0", VA = "0x18147D8C0", Slot = "10")]
		public override void DeserializeFromProtobuf(CircuitContextData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x147EF90", Offset = "0x147D990", VA = "0x18147EF90")]
		public void PushEditContext(CircuitContext circuitContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x147EE20", Offset = "0x147D820", VA = "0x18147EE20")]
		public void PopEditContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x147F280", Offset = "0x147DC80", VA = "0x18147F280")]
		public void RaiseRegisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x147F300", Offset = "0x147DD00", VA = "0x18147F300")]
		public void RaiseUnregisteredEventGlobal(CircuitContext context, CircuitEventDefinition circuitEventDefinition, bool isBuiltIn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x147F150", Offset = "0x147DB50", VA = "0x18147F150")]
		public void RaiseOnCircuitNodeDestroyedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x147F0E0", Offset = "0x147DAE0", VA = "0x18147F0E0")]
		public void RaiseOnCircuitNodeAddedGlobal(CircuitContext context, Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x147F1C0", Offset = "0x147DBC0", VA = "0x18147F1C0")]
		public void RaiseOnCircuitNodesConnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x147F220", Offset = "0x147DC20", VA = "0x18147F220")]
		public void RaiseOnCircuitNodesDisconnectedAllContexts(NodeConnection nodeConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x147F380", Offset = "0x147DD80", VA = "0x18147F380")]
		public void RegisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1480C00", Offset = "0x147F600", VA = "0x181480C00")]
		public void UnregisterTemplatedContext(Guid templateId, CircuitContext templatedContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x147EDC0", Offset = "0x147D7C0", VA = "0x18147EDC0")]
		private void OnBufferedOpCountChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x147DA00", Offset = "0x147C400", VA = "0x18147DA00")]
		public void MasterReinitialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1480550", Offset = "0x147EF50", VA = "0x181480550")]
		[RPCMethod]
		protected void RpcReinitializeAll(CircuitContextData circuitContextData, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x147F5E0", Offset = "0x147DFE0", VA = "0x18147F5E0")]
		internal void RequestCreateNewCircuitNode(Guid contextId, Type circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x147DC00", Offset = "0x147C600", VA = "0x18147DC00")]
		[RPCMethod]
		internal void MasterRpcCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x147FD80", Offset = "0x147E780", VA = "0x18147FD80")]
		[RPCMethod]
		internal void RpcBufferedCreateNewCircuitNode(Guid contextId, Guid circuitNodeType, Guid circuitNodeId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x147F9A0", Offset = "0x147E3A0", VA = "0x18147F9A0")]
		internal void RequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x147E7B0", Offset = "0x147D1B0", VA = "0x18147E7B0")]
		[RPCMethod]
		internal void MasterRpcRequestDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1480050", Offset = "0x147EA50", VA = "0x181480050")]
		[RPCMethod]
		internal void RpcBufferedDestroyCircuitNode(Guid contextId, Guid circuitNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x147F7F0", Offset = "0x147E1F0", VA = "0x18147F7F0")]
		internal void RequestCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x147DED0", Offset = "0x147C8D0", VA = "0x18147DED0")]
		[RPCMethod]
		internal void MasterRpcCreateNewDynamicEvent(Guid contextId, string eventName, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x147FF30", Offset = "0x147E930", VA = "0x18147FF30")]
		[RPCMethod]
		internal void RpcBufferedCreateNewDynamicEvent(Guid contextId, string eventName, Guid eventId, Vector3 localSpacePosition, Quaternion localSpaceRotation, RPCInfo rpcInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x147FA80", Offset = "0x147E480", VA = "0x18147FA80")]
		internal void RequestDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x147E1C0", Offset = "0x147CBC0", VA = "0x18147E1C0")]
		[RPCMethod]
		internal void MasterRpcDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x14800B0", Offset = "0x147EAB0", VA = "0x1814800B0")]
		[RPCMethod]
		internal void RpcBufferedDestroyDynamicEvent(Guid contextId, Guid eventId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x147F400", Offset = "0x147DE00", VA = "0x18147F400")]
		internal void RequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x147E540", Offset = "0x147CF40", VA = "0x18147E540")]
		[RPCMethod]
		internal void MasterRpcRequestConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1480180", Offset = "0x147EB80", VA = "0x181480180")]
		[RPCMethod]
		internal void RpcConnect(Guid contextId, Guid srcNode, Guid srcPort, Guid dstNode, Guid dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x147FBE0", Offset = "0x147E5E0", VA = "0x18147FBE0")]
		internal void RequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x147E910", Offset = "0x147D310", VA = "0x18147E910")]
		[RPCMethod]
		internal void MasterRpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1480600", Offset = "0x147F000", VA = "0x181480600")]
		[RPCMethod]
		internal void RpcRequestDisconnectPort(Guid contextId, Guid node, Guid port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1480820", Offset = "0x147F220", VA = "0x181480820")]
		internal void SendObjectModification(ICircuitObjectModification nodeModificationBase)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x147E380", Offset = "0x147CD80", VA = "0x18147E380")]
		[RPCMethod]
		internal void MasterRpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1480350", Offset = "0x147ED50", VA = "0x181480350")]
		[RPCMethod]
		internal void RpcHandleNodeModification(ModificationData modificationData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x147EB20", Offset = "0x147D520", VA = "0x18147EB20")]
		public IEnumerable<CircuitObject> MasterSpawnTemplateOnAllClients(CircuitContext intoContext, CircuitContextData templateDataOriginal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x14807D0", Offset = "0x147F1D0", VA = "0x1814807D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x413B20", Offset = "0x412520", VA = "0x180413B20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x18DB3B0", Offset = "0x18D9DB0", VA = "0x1818DB3B0")]
		public NestedCircuitContext(Guid contextId, ObjectCircuitContext parentSynchronizationContext, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x18DB2C0", Offset = "0x18D9CC0", VA = "0x1818DB2C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DB650", Offset = "0x18DA050", VA = "0x1818DB650")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x18DB6F0", Offset = "0x18DA0F0", VA = "0x1818DB6F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x18DB5E0", Offset = "0x18D9FE0", VA = "0x1818DB5E0")]
		public ObjectCircuitContext(Guid contextId, GlobalCircuitContext rootContext, Dependencies recRoomDependencies, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x18DB540", Offset = "0x18D9F40", VA = "0x1818DB540")]
		public void SetSynchronizationBackend(ICircuitContextNetworking networkBackend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x18DB430", Offset = "0x18D9E30", VA = "0x1818DB430", Slot = "8")]
		public override CircuitContext CreateChildContext(Guid newContextGuid, [Optional] Guid? templateId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x18DB510", Offset = "0x18D9F10", VA = "0x1818DB510", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x413B20", Offset = "0x412520", VA = "0x180413B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IContextSynchronizedFieldFactory SynchronizedFieldFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x1D60240", Offset = "0x1D5EC40", VA = "0x181D60240")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B3A10", Offset = "0x4B2410", VA = "0x1804B3A10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool HasAuthority
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1D601F0", Offset = "0x1D5EBF0", VA = "0x181D601F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1D60120", Offset = "0x1D5EB20", VA = "0x181D60120")]
		public SynchronizedCircuitContext(Guid contextId, Dependencies recRoomDependencies, GlobalCircuitContext rootContext, Guid? templateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FAD0", Offset = "0x1D5E4D0", VA = "0x181D5FAD0", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F9E0", Offset = "0x1D5E3E0", VA = "0x181D5F9E0")]
		public void AddChildContextToLookup(CircuitContext childContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FC70", Offset = "0x1D5E670", VA = "0x181D5FC70")]
		public void RemoveChildContextFromLookup(Guid childContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FED0", Offset = "0x1D5E8D0", VA = "0x181D5FED0")]
		public void SendSynchronizedEvent(Guid fromContextId, CircuitEvent circuitEvent, SyncedEventTargets syncedEventTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FD50", Offset = "0x1D5E750", VA = "0x181D5FD50")]
		[RPCMethod]
		protected void RpcOnReceivedSynchronizedEvent(Guid contextId, SynchronizedEventData circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FB20", Offset = "0x1D5E520", VA = "0x181D5FB20")]
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
			[Cpp2IlInjected.Address(RVA = "0x1447D0", Offset = "0x143BD0", VA = "0x1801447D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int IntValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x13AF80", Offset = "0x13A380", VA = "0x18013AF80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FloatValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x157320", Offset = "0x156720", VA = "0x180157320")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CircuitPlayer PlayerValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x18F350", Offset = "0x18E750", VA = "0x18018F350")]
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
			[Cpp2IlInjected.Address(RVA = "0x18F380", Offset = "0x18E780", VA = "0x18018F380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x145530", Offset = "0x144930", VA = "0x180145530")]
		public object ObjectValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x157A70", Offset = "0x156E70", VA = "0x180157A70")]
		public T ObjectValue<T>()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x18F330", Offset = "0x18E730", VA = "0x18018F330")]
		private CircuitSignal(TypeKind circuitTypeKind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x18EDB0", Offset = "0x18E1B0", VA = "0x18018EDB0")]
		public bool Equals(CircuitSignal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x18EE50", Offset = "0x18E250", VA = "0x18018EE50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x18EF70", Offset = "0x18E370", VA = "0x18018EF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x147BD40", Offset = "0x147A740", VA = "0x18147BD40")]
		public static bool operator !=(CircuitSignal left, CircuitSignal right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x18F0F0", Offset = "0x18E4F0", VA = "0x18018F0F0")]
		public string InternalToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x18F200", Offset = "0x18E600", VA = "0x18018F200")]
		internal CircuitSignalData ToSerializedSignalData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x147B650", Offset = "0x147A050", VA = "0x18147B650")]
		internal static CircuitSignal FromSerializedSignalData(CircuitSignalData signalData)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x147B330", Offset = "0x1479D30", VA = "0x18147B330")]
		public static CircuitSignal DefaultFor(TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x147B540", Offset = "0x1479F40", VA = "0x18147B540")]
		public static CircuitSignal FromBool(bool newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x147B5D0", Offset = "0x1479FD0", VA = "0x18147B5D0")]
		public static CircuitSignal FromInt(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x147B590", Offset = "0x1479F90", VA = "0x18147B590")]
		public static CircuitSignal FromFloat(float newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x147B7F0", Offset = "0x147A1F0", VA = "0x18147B7F0")]
		public static CircuitSignal FromString(string stringValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x147B5D0", Offset = "0x1479FD0", VA = "0x18147B5D0")]
		public static CircuitSignal FromPlayerID(int newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x147B5D0", Offset = "0x1479FD0", VA = "0x18147B5D0")]
		public static CircuitSignal FromPlayer(CircuitPlayer newValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x147B610", Offset = "0x147A010", VA = "0x18147B610")]
		public static CircuitSignal FromObject(object newValue, TypeKind typeKind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x147BB30", Offset = "0x147A530", VA = "0x18147BB30")]
		public static CircuitSignal List(List<CircuitSignal> list)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x147B090", Offset = "0x1479A90", VA = "0x18147B090")]
		public static CircuitSignal CreateListFromPorts(IExecutionScope executionScope, IReadOnlyCollection<InputPort> valuePorts, bool includeUnconnected)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x18F040", Offset = "0x18E440", VA = "0x18018F040")]
		public List<CircuitSignal> GetListValue()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x147B540", Offset = "0x1479F40", VA = "0x18147B540")]
		public static explicit operator CircuitSignal(bool boolValue)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x147B590", Offset = "0x1479F90", VA = "0x18147B590")]
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
		[Cpp2IlInjected.Address(RVA = "0x147C220", Offset = "0x147AC20", VA = "0x18147C220")]
		public static implicit operator CircuitTypeOrString(string value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x147C1F0", Offset = "0x147ABF0", VA = "0x18147C1F0")]
		public static implicit operator CircuitTypeOrString(CircuitType value)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x18F560", Offset = "0x18E960", VA = "0x18018F560")]
		public CircuitType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x147C080", Offset = "0x147AA80", VA = "0x18147C080")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D61660", Offset = "0x1D60060", VA = "0x181D61660")]
		public static implicit operator TypeParamConstrainedOrNot(string name)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1D616F0", Offset = "0x1D600F0", VA = "0x181D616F0")]
		public static implicit operator TypeParamConstrainedOrNot([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5C3C0", Offset = "0x5B7C0")] (string, CircuitTypeOrString) fields)
		{
			return default(TypeParamConstrainedOrNot);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x140640", Offset = "0x13FA40", VA = "0x180140640")]
		public TypeParameterType Into()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x1D61560", Offset = "0x1D5FF60", VA = "0x181D61560")]
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
		[Cpp2IlInjected.Address(RVA = "0x147C720", Offset = "0x147B120", VA = "0x18147C720")]
		public ClassFactoryTypeParams(Guid? name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x147C440", Offset = "0x147AE40", VA = "0x18147C440")]
		public ClassFactoryTypeParams CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x147C560", Offset = "0x147AF60", VA = "0x18147C560")]
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
		[Cpp2IlInjected.Address(RVA = "0x147C370", Offset = "0x147AD70", VA = "0x18147C370")]
		public ClassFactoryProps(Guid? name, string friendlyName, IList<TypeParameterType> typeParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x147C260", Offset = "0x147AC60", VA = "0x18147C260")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D62660", Offset = "0x1D61060", VA = "0x181D62660")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D633B0", Offset = "0x1D61DB0", VA = "0x181D633B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static CircuitType CInt
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x1D63570", Offset = "0x1D61F70", VA = "0x181D63570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static CircuitType CFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1D63500", Offset = "0x1D61F00", VA = "0x181D63500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static CircuitType CString
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x1D635E0", Offset = "0x1D61FE0", VA = "0x181D635E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static CircuitType CAny
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x1D63340", Offset = "0x1D61D40", VA = "0x181D63340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static CircuitType CExec
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1D63490", Offset = "0x1D61E90", VA = "0x181D63490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static CircuitType CErr
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1D63420", Offset = "0x1D61E20", VA = "0x181D63420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1D62C20", Offset = "0x1D61620", VA = "0x181D62C20")]
		public static AppliedGenericType CArray(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1D62E90", Offset = "0x1D61890", VA = "0x181D62E90")]
		public static AppliedGenericType CList(CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1D62D10", Offset = "0x1D61710", VA = "0x181D62D10")]
		public static ClassFactoryTypeParams CClass()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1D62D80", Offset = "0x1D61780", VA = "0x181D62D80")]
		public static ClassFactoryTypeParams CClass(Guid name, string friendlyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1D62E20", Offset = "0x1D61820", VA = "0x181D62E20")]
		public static AppliedGenericType CIntersect(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1D62F90", Offset = "0x1D61990", VA = "0x181D62F90")]
		public static AppliedGenericType CTuple(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1D63000", Offset = "0x1D61A00", VA = "0x181D63000")]
		public static TypeParameterType CTypeParam(string name, [Optional] CircuitTypeOrString? constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1D630D0", Offset = "0x1D61AD0", VA = "0x181D630D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D4F1B0", Offset = "0x1D4DBB0", VA = "0x181D4F1B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E7C0", Offset = "0x1D4D1C0", VA = "0x181D4E7C0", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1D4E8A0", Offset = "0x1D4D2A0", VA = "0x181D4E8A0", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F130", Offset = "0x1D4DB30", VA = "0x181D4F130")]
		public AppliedGenericType(GenericType originalType, IEnumerable<CircuitType> typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F0F0", Offset = "0x1D4DAF0", VA = "0x181D4F0F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1D4ED90", Offset = "0x1D4D790", VA = "0x181D4ED90", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x1D4ED00", Offset = "0x1D4D700", VA = "0x181D4ED00", Slot = "10")]
		public bool Equals(AppliedGenericType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1D4EE60", Offset = "0x1D4D860", VA = "0x181D4EE60", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1D4EEB0", Offset = "0x1D4D8B0", VA = "0x181D4EEB0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1D4EF30", Offset = "0x1D4D930", VA = "0x181D4EF30", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1D4EAF0", Offset = "0x1D4D4F0", VA = "0x181D4EAF0")]
		public static AppliedGenericType DeserializeFromProtobuf(AppliedGenericTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class ArrayType : GenericType, IEquatable<ArrayType>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F480", Offset = "0x1D4DE80", VA = "0x181D4F480")]
		public ArrayType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F420", Offset = "0x1D4DE20", VA = "0x181D4F420", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F390", Offset = "0x1D4DD90", VA = "0x181D4F390", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F350", Offset = "0x1D4DD50", VA = "0x181D4F350")]
		private static string ToStringImpl(string typeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F2F0", Offset = "0x1D4DCF0", VA = "0x181D4F2F0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E10", Offset = "0x3A5810", VA = "0x1803A6E10", Slot = "11")]
		public bool Equals(ArrayType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F2A0", Offset = "0x1D4DCA0", VA = "0x181D4F2A0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F340", Offset = "0x1D4DD40", VA = "0x181D4F340", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B9330", Offset = "0x4B7D30", VA = "0x1804B9330")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x388C20", Offset = "0x387620", VA = "0x180388C20")]
		public CircuitType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A10", Offset = "0x4B2410", VA = "0x1804B3A10", Slot = "5")]
		public virtual CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x15E8DA0", Offset = "0x15E77A0", VA = "0x1815E8DA0", Slot = "7")]
		public virtual void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x15E9290", Offset = "0x15E7C90", VA = "0x1815E9290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x15E9130", Offset = "0x15E7B30", VA = "0x1815E9130", Slot = "8")]
		public virtual bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x15E90E0", Offset = "0x15E7AE0", VA = "0x1815E90E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x15E9390", Offset = "0x15E7D90", VA = "0x1815E9390")]
		public static bool operator ==(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x15E93B0", Offset = "0x15E7DB0", VA = "0x1815E93B0")]
		public static bool operator !=(CircuitType lhs, CircuitType rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x15E91F0", Offset = "0x15E7BF0", VA = "0x1815E91F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x15E9210", Offset = "0x15E7C10", VA = "0x1815E9210", Slot = "9")]
		public virtual CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x15E8E00", Offset = "0x15E7800", VA = "0x1815E8E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
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
			[Cpp2IlInjected.Address(RVA = "0x15EA5C0", Offset = "0x15E8FC0", VA = "0x1815EA5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x15EA490", Offset = "0x15E8E90", VA = "0x1815EA490")]
		public ClassType([Optional] IEnumerable<TypeParameterType> typeParameters, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] Guid? name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x15EA160", Offset = "0x15E8B60", VA = "0x1815EA160", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x15E93F0", Offset = "0x15E7DF0", VA = "0x1815E93F0")]
		private string ClassNameToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x15EA410", Offset = "0x15E8E10", VA = "0x1815EA410")]
		private string TypeParametersToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x15E9D40", Offset = "0x15E8740", VA = "0x1815E9D40")]
		private string PropertiesToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x13B4B90", Offset = "0x13B3590", VA = "0x1813B4B90", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParamaterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x15E99C0", Offset = "0x15E83C0", VA = "0x1815E99C0", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x15E9810", Offset = "0x15E8210", VA = "0x1815E9810", Slot = "11")]
		public bool Equals(ClassType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x15E97C0", Offset = "0x15E81C0", VA = "0x1815E97C0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x15E9BB0", Offset = "0x15E85B0", VA = "0x1815E9BB0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x15E9EB0", Offset = "0x15E88B0", VA = "0x1815E9EB0", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x15E94B0", Offset = "0x15E7EB0", VA = "0x1815E94B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
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
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x15EB420", Offset = "0x15E9E20", VA = "0x1815EB420")]
		public FunctionType(IEnumerable<TypeParameterType> typeParameters, IEnumerable<KeyValuePair<string, Parameter>> parameters, IEnumerable<KeyValuePair<string, Return>> returns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x15EB3F0", Offset = "0x15E9DF0", VA = "0x1815EB3F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x15EB3C0", Offset = "0x15E9DC0", VA = "0x1815EB3C0", Slot = "10")]
		public sealed override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x15EAE00", Offset = "0x15E9800", VA = "0x1815EAE00", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x15EAEF0", Offset = "0x15E98F0", VA = "0x1815EAEF0", Slot = "11")]
		public bool Equals(FunctionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x15EADB0", Offset = "0x15E97B0", VA = "0x1815EADB0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x15EAFA0", Offset = "0x15E99A0", VA = "0x1815EAFA0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x15EB060", Offset = "0x15E9A60", VA = "0x1815EB060", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x15EAA80", Offset = "0x15E9480", VA = "0x1815EAA80")]
		public static FunctionType DeserializeFromProtobuf(FunctionTypeData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class GenericType : CircuitType
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x388C20", Offset = "0x387620", VA = "0x180388C20")]
		protected GenericType(TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract string ToString(IReadOnlyList<CircuitType> typeParameterAssignments);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x15EB550", Offset = "0x15E9F50", VA = "0x1815EB550")]
		public AppliedGenericType NewApplication(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x15EB4E0", Offset = "0x15E9EE0", VA = "0x1815EB4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15EC1A0", Offset = "0x15EABA0", VA = "0x1815EC1A0")]
		public IntersectionType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x15EC170", Offset = "0x15EAB70", VA = "0x1815EC170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x15EC0D0", Offset = "0x15EAAD0", VA = "0x1815EC0D0", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x15EC080", Offset = "0x15EAA80", VA = "0x1815EC080", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E10", Offset = "0x3A5810", VA = "0x1803A6E10", Slot = "11")]
		public bool Equals(IntersectionType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x15EC030", Offset = "0x15EAA30", VA = "0x1815EC030", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x15E91F0", Offset = "0x15E7BF0", VA = "0x1815E91F0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x38FA60", Offset = "0x38E460", VA = "0x18038FA60")]
		public Parameter(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x15EC590", Offset = "0x15EAF90", VA = "0x1815EC590", Slot = "4")]
		public bool Equals(Parameter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x15EC5D0", Offset = "0x15EAFD0", VA = "0x1815EC5D0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x10984D0", Offset = "0x1096ED0", VA = "0x1810984D0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x15EC620", Offset = "0x15EB020", VA = "0x1815EC620")]
		public ParameterData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x15EC510", Offset = "0x15EAF10", VA = "0x1815EC510")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x44CB80", Offset = "0x44B580", VA = "0x18044CB80")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C6AC0", Offset = "0x4C54C0", VA = "0x1804C6AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x15ECAB0", Offset = "0x15EB4B0", VA = "0x1815ECAB0")]
		public Property(CircuitType type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x15EC9F0", Offset = "0x15EB3F0", VA = "0x1815EC9F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x15EC8C0", Offset = "0x15EB2C0", VA = "0x1815EC8C0")]
		private string GetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x15EC9B0", Offset = "0x15EB3B0", VA = "0x1815EC9B0")]
		private string SetToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x15EC760", Offset = "0x15EB160", VA = "0x1815EC760", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x15EC7F0", Offset = "0x15EB1F0", VA = "0x1815EC7F0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x15EC840", Offset = "0x15EB240", VA = "0x1815EC840", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x15EC900", Offset = "0x15EB300", VA = "0x1815EC900")]
		public PropertyData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x15EC6B0", Offset = "0x15EB0B0", VA = "0x1815EC6B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x38FA60", Offset = "0x38E460", VA = "0x18038FA60")]
		public Return(CircuitType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x15EC590", Offset = "0x15EAF90", VA = "0x1815EC590", Slot = "4")]
		public bool Equals(Return other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x15ED8E0", Offset = "0x15EC2E0", VA = "0x1815ED8E0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x10984D0", Offset = "0x1096ED0", VA = "0x1810984D0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x15ED930", Offset = "0x15EC330", VA = "0x1815ED930")]
		public ReturnData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x15ED860", Offset = "0x15EC260", VA = "0x1815ED860")]
		public static Return DeserializeFromProtobuf(ReturnData protobufData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class TupleType : GenericType, IEquatable<TupleType>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x15EEB30", Offset = "0x15ED530", VA = "0x1815EEB30")]
		public TupleType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x15EEB00", Offset = "0x15ED500", VA = "0x1815EEB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x15EEAA0", Offset = "0x15ED4A0", VA = "0x1815EEAA0", Slot = "10")]
		public override string ToString(IReadOnlyList<CircuitType> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x15EEA50", Offset = "0x15ED450", VA = "0x1815EEA50", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E10", Offset = "0x3A5810", VA = "0x1803A6E10", Slot = "11")]
		public bool Equals(TupleType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x15EEA00", Offset = "0x15ED400", VA = "0x1815EEA00", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x15E91F0", Offset = "0x15E7BF0", VA = "0x1815E91F0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4230", Offset = "0x3A2C30", VA = "0x1803A4230", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x15EEB50", Offset = "0x15ED550", VA = "0x1815EEB50", Slot = "5")]
		public sealed override CircuitType ApplyTypeParameters(IReadOnlyDictionary<string, CircuitType> typeSubstitutions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x15EEC40", Offset = "0x15ED640", VA = "0x1815EEC40", Slot = "7")]
		public sealed override void CrawlAppliedTypeParameters(Action<CircuitType> onPrimitiveVisit, Action<TypeParameterReferenceType> onReferenceVisit, Action<AppliedGenericType> onAppliedEntry, Action<AppliedGenericType> onAppliedExit)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x15EEF20", Offset = "0x15ED920", VA = "0x1815EEF20")]
		public TypeParameterReferenceType(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x15EED70", Offset = "0x15ED770", VA = "0x1815EED70", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x15EEDF0", Offset = "0x15ED7F0", VA = "0x1815EEDF0", Slot = "10")]
		public bool Equals(TypeParameterReferenceType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x15EED20", Offset = "0x15ED720", VA = "0x1815EED20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x15EEE20", Offset = "0x15ED820", VA = "0x1815EEE20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x15EEE70", Offset = "0x15ED870", VA = "0x1815EEE70", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x15EECA0", Offset = "0x15ED6A0", VA = "0x1815EECA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x15EF010", Offset = "0x15EDA10", VA = "0x1815EF010")]
		protected TypeParameterScopeType(IEnumerable<TypeParameterType> typeParameters, TypeKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract override bool Equals(CircuitType other);

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x15EEF50", Offset = "0x15ED950", VA = "0x1815EEF50")]
		protected bool Equals(TypeParameterScopeType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x15EEFB0", Offset = "0x15ED9B0", VA = "0x1815EEFB0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x15EF4A0", Offset = "0x15EDEA0", VA = "0x1815EF4A0")]
		public TypeParameterType(string name, [Optional] CircuitType constraint)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x15EF420", Offset = "0x15EDE20", VA = "0x1815EF420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x15EF220", Offset = "0x15EDC20", VA = "0x1815EF220", Slot = "8")]
		public override bool Equals(CircuitType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x15EF160", Offset = "0x15EDB60", VA = "0x1815EF160", Slot = "10")]
		public bool Equals(TypeParameterType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x15EF1D0", Offset = "0x15EDBD0", VA = "0x1815EF1D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x15EF2D0", Offset = "0x15EDCD0", VA = "0x1815EF2D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x15EF350", Offset = "0x15EDD50", VA = "0x1815EF350", Slot = "9")]
		public sealed override CircuitTypeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x15EF080", Offset = "0x15EDA80", VA = "0x1815EF080")]
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
		[Cpp2IlInjected.Address(RVA = "0x1138120", Offset = "0x1136B20", VA = "0x181138120")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(params TNode[] nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1137FD0", Offset = "0x11369D0", VA = "0x181137FD0")]
		public static Dictionary<TNode, List<(string, CircuitType)>> InferTypes<TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TNode> nodes) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1225860", Offset = "0x1224260", VA = "0x181225860")]
		private static (Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>) GenerateConstraintsForNodes<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(IEnumerable<TNode> nodes, TUnificationArena unificationArena) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((Dictionary<int, TypeParameterId<TNode>>, List<(int, CircuitType)>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x1BA5A30", Offset = "0x1BA4430", VA = "0x181BA5A30")]
		private static void GenerateConstraintsForNode<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToId, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToIdAll, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5E420", Offset = "0x5D820")] List<(int, CircuitType)> idToType, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5F940", Offset = "0x5ED40")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1137E70", Offset = "0x1136870", VA = "0x181137E70")]
		private static Dictionary<string, int> IdentifyTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TNode node, TUnificationArena unificationArena, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5FC70", Offset = "0x5F070")] List<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1122790", Offset = "0x1121190", VA = "0x181122790")]
		private static IEnumerable<(TPort, int)> GetGenericPorts<TPort, TUnificationArena, TTerm, TNode, TNode, TInputPort, TOutputPort, TCheckableConnection>(IEnumerable<TPort> ports, TUnificationArena unificationArena, Dictionary<ICheckablePort, int> portToTypeId) where TPort : class, ICheckablePort where TUnificationArena : IUnificationArena<TTerm> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1226280", Offset = "0x1224C80", VA = "0x181226280")]
		private static (int, TTerm) GenerateOutputConstraintsAndId<TTerm, TOutputPort, TNode, TInputPort, TCheckableConnection, TUnificationArena>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x5FEA0", Offset = "0x5F2A0")] IEnumerable<(TOutputPort, int)> outputPorts, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60060", Offset = "0x5F460")] List<(int, CircuitType)> idToType, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default((int, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x1BA6540", Offset = "0x1BA4F40", VA = "0x181BA6540")]
		private static void GenerateInputConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60470", Offset = "0x5F870")] IEnumerable<(TInputPort, int)> inputPorts, TUnificationArena unificationArena, int outputPortId, TTerm outputPortUnificationTerm, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x605B0", Offset = "0x5F9B0")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Dictionary<string, int> typeParameterToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x13492C0", Offset = "0x1347CC0", VA = "0x1813492C0")]
		private static int GenerateInputConnectionConstraintsAndId<TInputPort, TNode, TOutputPort, TCheckableConnection, TUnificationArena, TTerm>(TInputPort inputPort, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x606B0", Offset = "0x5FAB0")] List<(int, CircuitType)> idToType, Dictionary<ICheckablePort, int> portToId, Stack<TNode> potentialNodes) where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection> where TUnificationArena : IUnificationArena<TTerm>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1663A00", Offset = "0x1662400", VA = "0x181663A00")]
		private static TTerm GetTypeUnificationTerm<TTerm, TUnificationArena>(CircuitType type, TUnificationArena unificationArena, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60830", Offset = "0x5FC30")] List<(int, CircuitType)> idToType, IReadOnlyDictionary<string, int> typeParameterToId) where TUnificationArena : IUnificationArena<TTerm>
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1137760", Offset = "0x1136160", VA = "0x181137760")]
		private static Dictionary<TNode, List<(string, CircuitType)>> GetTypeParameterAssignments<TNode, TInputPort, TOutputPort, TCheckableConnection>(ReferenceSubstitution[] substitutions, Dictionary<int, TypeParameterId<TNode>> idToTypeParameter, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60960", Offset = "0x5FD60")] IEnumerable<(int, CircuitType)> idToType) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x1BA4C60", Offset = "0x1BA3660", VA = "0x181BA4C60")]
		private static void CacheAdditionalEquivalentTypeParameters<TNode, TInputPort, TOutputPort, TCheckableConnection>(TNode node, Stack<TNode> potentialNodes, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60C50", Offset = "0x60050")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TNode : class, ICheckableNode<TNode, TInputPort, TOutputPort, TCheckableConnection> where TInputPort : class, ICheckableInputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TOutputPort : class, ICheckableOutputPort<TNode, TInputPort, TOutputPort, TCheckableConnection> where TCheckableConnection : class, ICheckableConnection<TNode, TInputPort, TOutputPort, TCheckableConnection>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1BA5390", Offset = "0x1BA3D90", VA = "0x181BA5390")]
		private static void GenerateConstraintsForAdditionalEquivalentTypeParameters<TUnificationArena, TTerm, TNode>(TUnificationArena unificationArena, Dictionary<TypeParameterId<TNode>, int> typeParameterToId, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60EB0", Offset = "0x602B0")] List<(TypeParameterId<TNode>, TypeParameterId<TNode>)> additionalEquivalentTypeParameters) where TUnificationArena : IUnificationArena<TTerm>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1D60C90", Offset = "0x1D5F690", VA = "0x181D60C90")]
		private static Dictionary<int, CircuitType> ApplySubstitutions(Dictionary<int, ReferenceSubstitution> substitutions, [Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x60FF0", Offset = "0x603F0")] IEnumerable<(int, CircuitType)> idToType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1D61180", Offset = "0x1D5FB80", VA = "0x181D61180")]
		private static CircuitType MonomorphizeItem(ITerm type, Dictionary<int, CircuitType> idToType, Dictionary<int, CircuitType> cache)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1D61030", Offset = "0x1D5FA30", VA = "0x181D61030")]
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
			[Cpp2IlInjected.Address(RVA = "0x140640", Offset = "0x13FA40", VA = "0x180140640")]
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
			[Cpp2IlInjected.Address(RVA = "0x145530", Offset = "0x144930", VA = "0x180145530")]
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
		[Cpp2IlInjected.Address(RVA = "0x23A730", Offset = "0x239B30", VA = "0x18023A730", Slot = "4")]
		public bool Equals(TypeParameterId<TNode> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x23A800", Offset = "0x239C00", VA = "0x18023A800", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x23A890", Offset = "0x239C90", VA = "0x18023A890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x23A920", Offset = "0x239D20", VA = "0x18023A920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class TypeParameterId
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x96BA40", Offset = "0x96A440", VA = "0x18096BA40")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x63690", Offset = "0x62A90")]
			public readonly (Constraint, Constraint) constraints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public readonly Substitution substitution;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1ADC40", Offset = "0x1AD040", VA = "0x1801ADC40")]
			public Impl(in Constraint first, in Constraint second)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x1ADC50", Offset = "0x1AD050", VA = "0x1801ADC50")]
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
			[Cpp2IlInjected.Address(RVA = "0x136860", Offset = "0x135C60", VA = "0x180136860")]
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
			[Cpp2IlInjected.Address(RVA = "0x140640", Offset = "0x13FA40", VA = "0x180140640")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Constraint SecondConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x145530", Offset = "0x144930", VA = "0x180145530")]
			get
			{
				return default(Constraint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Substitution Substitution
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x140640", Offset = "0x13FA40", VA = "0x180140640")]
			get
			{
				return default(Substitution);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB40", Offset = "0x1ACF40", VA = "0x1801ADB40")]
		private ApplyConstraintResult(in Constraint first, in Constraint second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x15DC1E0", Offset = "0x15DABE0", VA = "0x1815DC1E0")]
		public static ApplyConstraintResult NewConstraints(in Constraint first, in Constraint second)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB10", Offset = "0x1ACF10", VA = "0x1801ADB10")]
		private ApplyConstraintResult(in Substitution substitution)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x15DC290", Offset = "0x15DAC90", VA = "0x1815DC290")]
		public static ApplyConstraintResult NewSubstitution(in Substitution substitution)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB50", Offset = "0x1ACF50", VA = "0x1801ADB50")]
		private ApplyConstraintResult(ApplyConstraintResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x15DC270", Offset = "0x15DAC70", VA = "0x1815DC270")]
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
			[Cpp2IlInjected.Address(RVA = "0x13AF80", Offset = "0x13A380", VA = "0x18013AF80")]
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
			[Cpp2IlInjected.Address(RVA = "0x13AF70", Offset = "0x13A370", VA = "0x18013AF70")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x1442E0", Offset = "0x1436E0", VA = "0x1801442E0")]
		public Arrow(TermIndex from, TermIndex to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB80", Offset = "0x1ACF80", VA = "0x1801ADB80", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x13AF80", Offset = "0x13A380", VA = "0x18013AF80")]
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
			[Cpp2IlInjected.Address(RVA = "0x13AF70", Offset = "0x13A370", VA = "0x18013AF70")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1ADB90", Offset = "0x1ACF90", VA = "0x1801ADB90")]
		public ApplyConstraintResult Apply(Term[] terms)
		{
			return default(ApplyConstraintResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1442E0", Offset = "0x1436E0", VA = "0x1801442E0")]
		public Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1ADBC0", Offset = "0x1ACFC0", VA = "0x1801ADBC0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x13AF80", Offset = "0x13A380", VA = "0x18013AF80")]
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
			[Cpp2IlInjected.Address(RVA = "0x13AF70", Offset = "0x13A370", VA = "0x18013AF70")]
			[CompilerGenerated]
			get
			{
				return default(TermIndex);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1442E0", Offset = "0x1436E0", VA = "0x1801442E0")]
		public Substitution(int identifier, TermIndex value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1ADCB0", Offset = "0x1AD0B0", VA = "0x1801ADCB0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x1ADC70", Offset = "0x1AD070", VA = "0x1801ADC70")]
			public Impl(in Arrow arrow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x1ADC80", Offset = "0x1AD080", VA = "0x1801ADC80")]
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
			[Cpp2IlInjected.Address(RVA = "0x143110", Offset = "0x142510", VA = "0x180143110")]
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
			[Cpp2IlInjected.Address(RVA = "0x140640", Offset = "0x13FA40", VA = "0x180140640")]
			get
			{
				return default(Arrow);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public int Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x13AF80", Offset = "0x13A380", VA = "0x18013AF80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1ADE90", Offset = "0x1AD290", VA = "0x1801ADE90")]
		private Term(in Arrow arrow)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x15EE9C0", Offset = "0x15ED3C0", VA = "0x1815EE9C0")]
		public static Term NewArrow(in Arrow arrow)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1ADEA0", Offset = "0x1AD2A0", VA = "0x1801ADEA0")]
		private Term(int identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x15EE9E0", Offset = "0x15ED3E0", VA = "0x1815EE9E0")]
		public static Term NewIdentifier(int identifier)
		{
			return default(Term);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1ADDA0", Offset = "0x1AD1A0", VA = "0x1801ADDA0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x13AF80", Offset = "0x13A380", VA = "0x18013AF80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x14AD40", Offset = "0x14A140", VA = "0x18014AD40")]
		public TermIndex(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1ADD40", Offset = "0x1AD140", VA = "0x1801ADD40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1ADD30", Offset = "0x1AD130", VA = "0x1801ADD30")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x38FA50", Offset = "0x38E450", VA = "0x18038FA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private Stack<Constraint> Constraints
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x15F3090", Offset = "0x15F1A90", VA = "0x1815F3090", Slot = "4")]
		public int NextId()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x13495A0", Offset = "0x1347FA0", VA = "0x1813495A0", Slot = "5")]
		public int GetId<T>(Dictionary<T, int> itemToIndex, T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x15F2ED0", Offset = "0x15F18D0", VA = "0x1815F2ED0", Slot = "6")]
		public TermIndex Arrow(TermIndex from, TermIndex to)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x38C210", Offset = "0x38AC10", VA = "0x18038C210", Slot = "7")]
		public TermIndex Identifier(int value)
		{
			return default(TermIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x15F2F80", Offset = "0x15F1980", VA = "0x1815F2F80", Slot = "8")]
		public void Constraint(TermIndex lhs, TermIndex rhs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x15F3130", Offset = "0x15F1B30", VA = "0x1815F3130", Slot = "9")]
		public ReferenceSubstitution[] Solve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x15F2FF0", Offset = "0x15F19F0", VA = "0x1815F2FF0")]
		public static UnificationArena New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x44BBA0", Offset = "0x44A5A0", VA = "0x18044BBA0", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x15ED380", Offset = "0x15EBD80", VA = "0x1815ED380", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3A8090", Offset = "0x3A6A90", VA = "0x1803A8090")]
		public ReferenceArrow(ITerm from, ITerm to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x15ED4F0", Offset = "0x15EBEF0", VA = "0x1815ED4F0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
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
			[Cpp2IlInjected.Address(RVA = "0x40AB40", Offset = "0x409540", VA = "0x18040AB40", Slot = "4")]
			get
			{
				return default(TermKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x15ED580", Offset = "0x15EBF80", VA = "0x1815ED580", Slot = "5")]
		public bool Equals(ITerm other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x388C20", Offset = "0x387620", VA = "0x180388C20")]
		public ReferenceIdentifier(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x15ED690", Offset = "0x15EC090", VA = "0x1815ED690", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xDD06C0", Offset = "0xDCF0C0", VA = "0x180DD06C0")]
		public ReferenceSubstitution(int identifier, ITerm value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x15ED810", Offset = "0x15EC210", VA = "0x1815ED810")]
		public ReferenceSubstitution(in Substitution substitution, Term[] terms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x15ED6B0", Offset = "0x15EC0B0", VA = "0x1815ED6B0")]
		private static ITerm FromTermIndex(TermIndex termIndex, Term[] terms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x15ED7B0", Offset = "0x15EC1B0", VA = "0x1815ED7B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x14AD40", Offset = "0x14A140", VA = "0x18014AD40")]
			public IntBytesUnion(int intVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x24A380", Offset = "0x249780", VA = "0x18024A380")]
			public IntBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x24A370", Offset = "0x249770", VA = "0x18024A370")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x1D4F530", Offset = "0x1D4DF30", VA = "0x181D4F530")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D5E440", Offset = "0x1D5CE40", VA = "0x181D5E440")]
		internal static bool TryGetTypeSerializer(CircuitType signalType, out ITypeSerializer typeSerializer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E2D0", Offset = "0x1D5CCD0", VA = "0x181D5E2D0")]
		public static void SerializeSignalForSync(Stream stream, CircuitType signalType, CircuitSignal signalValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E130", Offset = "0x1D5CB30", VA = "0x181D5E130")]
		public static CircuitSignal DeserializeSyncedSignal(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E750", Offset = "0x1D5D150", VA = "0x181D5E750")]
		public static void WriteInt(Stream stream, int intValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F530", Offset = "0x1D4DF30", VA = "0x181D4F530")]
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
		[Cpp2IlInjected.Address(RVA = "0xC34B80", Offset = "0xC33580", VA = "0x180C34B80", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F4F0", Offset = "0x1D4DEF0", VA = "0x181D4F4F0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F490", Offset = "0x1D4DE90", VA = "0x181D4F490", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		public BooleanSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal class IntSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xC34A10", Offset = "0xC33410", VA = "0x180C34A10", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F870", Offset = "0x1D4E270", VA = "0x181D4F870", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F7F0", Offset = "0x1D4E1F0", VA = "0x181D4F7F0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
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
			[Cpp2IlInjected.Address(RVA = "0x16D090", Offset = "0x16C490", VA = "0x18016D090")]
			public FloatBytesUnion(float floatVal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x24A380", Offset = "0x249780", VA = "0x18024A380")]
			public FloatBytesUnion(byte b0, byte b1, byte b2, byte b3)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x24A370", Offset = "0x249770", VA = "0x18024A370")]
			public void WriteToStream(Stream stream)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x1D4F530", Offset = "0x1D4DF30", VA = "0x181D4F530")]
			public static FloatBytesUnion ReadFromStream(Stream stream)
			{
				return default(FloatBytesUnion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F660", Offset = "0x1D4E060", VA = "0x181D4F660", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F760", Offset = "0x1D4E160", VA = "0x181D4F760", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F690", Offset = "0x1D4E090", VA = "0x181D4F690", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		public FloatSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal class StringSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E980", Offset = "0x1D5D380", VA = "0x181D5E980", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EB00", Offset = "0x1D5D500", VA = "0x181D5EB00", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E9B0", Offset = "0x1D5D3B0", VA = "0x181D5E9B0", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		public StringSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	internal class PlayerSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D56DD0", Offset = "0x1D557D0", VA = "0x181D56DD0", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D56EC0", Offset = "0x1D558C0", VA = "0x181D56EC0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D56E40", Offset = "0x1D55840", VA = "0x181D56E40", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		public PlayerSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal class ListSerializer : ITypeSerializer
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D50800", Offset = "0x1D4F200", VA = "0x181D50800", Slot = "4")]
		public bool CanSerialize(CircuitType circuitType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D50AB0", Offset = "0x1D4F4B0", VA = "0x181D50AB0", Slot = "5")]
		public void Serialize(Stream stream, CircuitType signalType, CircuitSignal signal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D50920", Offset = "0x1D4F320", VA = "0x181D50920", Slot = "6")]
		public CircuitSignal Deserialize(Stream stream, CircuitType signalType)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CE200", Offset = "0x18CCC00", VA = "0x1818CE200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x18CCEB0", Offset = "0x18CB8B0", VA = "0x1818CCEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CF750", Offset = "0x18CE150", VA = "0x1818CF750")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CF680", Offset = "0x18CE080", VA = "0x1818CF680")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CF7B0", Offset = "0x18CE1B0", VA = "0x1818CF7B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x18CF900", Offset = "0x18CE300", VA = "0x1818CF900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerNonUserCode]
		public ByteString NodeType
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x18CF9A0", Offset = "0x18CE3A0", VA = "0x1818CF9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[DebuggerNonUserCode]
		public PortCollectionData InputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[DebuggerNonUserCode]
		public PortCollectionData OutputPortCollection
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x391070", Offset = "0x38FA70", VA = "0x180391070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[DebuggerNonUserCode]
		public RepeatedField<NodeConnectionData> NodeConnectionDatas
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x3972D0", Offset = "0x395CD0", VA = "0x1803972D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3972E0", Offset = "0x395CE0", VA = "0x1803972E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x18CF950", Offset = "0x18CE350", VA = "0x1818CF950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x3972C0", Offset = "0x395CC0", VA = "0x1803972C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x3D3DA0", Offset = "0x3D27A0", VA = "0x1803D3DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x3D8600", Offset = "0x3D7000", VA = "0x1803D8600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x3D57E0", Offset = "0x3D41E0", VA = "0x1803D57E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[DebuggerNonUserCode]
		public ByteString InnerContextId
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x3ADAB0", Offset = "0x3AC4B0", VA = "0x1803ADAB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x18CF8B0", Offset = "0x18CE2B0", VA = "0x1818CF8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[DebuggerNonUserCode]
		public RepeatedField<EventRegistrationData> ListensToEventIds
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x39B5B0", Offset = "0x399FB0", VA = "0x18039B5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D4EA0", Offset = "0x3D38A0", VA = "0x1803D4EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x413C10", Offset = "0x412610", VA = "0x180413C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x470D60", Offset = "0x46F760", VA = "0x180470D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[DebuggerNonUserCode]
		public VariableNodeData VariableNodeData
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x413C40", Offset = "0x412640", VA = "0x180413C40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x4C78A0", Offset = "0x4C62A0", VA = "0x1804C78A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x18CF430", Offset = "0x18CDE30", VA = "0x1818CF430")]
		[DebuggerNonUserCode]
		public CircuitNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x18CF520", Offset = "0x18CDF20", VA = "0x1818CF520")]
		[DebuggerNonUserCode]
		public CircuitNodeData(CircuitNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x18CE5E0", Offset = "0x18CCFE0", VA = "0x1818CE5E0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x18CE860", Offset = "0x18CD260", VA = "0x1818CE860", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x18CE640", Offset = "0x18CD040", VA = "0x1818CE640", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x18CE8C0", Offset = "0x18CD2C0", VA = "0x1818CE8C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x18CEEA0", Offset = "0x18CD8A0", VA = "0x1818CEEA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x18CEF00", Offset = "0x18CD900", VA = "0x1818CEF00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x18CE260", Offset = "0x18CCC60", VA = "0x1818CE260", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x18CEAD0", Offset = "0x18CD4D0", VA = "0x1818CEAD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D0500", Offset = "0x18CEF00", VA = "0x1818D0500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x18CF9F0", Offset = "0x18CE3F0", VA = "0x1818CF9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D68C90", Offset = "0x1D67690", VA = "0x181D68C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D68C10", Offset = "0x1D67610", VA = "0x181D68C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D68CF0", Offset = "0x1D676F0", VA = "0x181D68CF0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x452340", Offset = "0x450D40", VA = "0x180452340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x452620", Offset = "0x451020", VA = "0x180452620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x452610", Offset = "0x451010", VA = "0x180452610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x452630", Offset = "0x451030", VA = "0x180452630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8A0", Offset = "0x3AE2A0", VA = "0x1803AF8A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x3AF890", Offset = "0x3AE290", VA = "0x1803AF890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		[DebuggerNonUserCode]
		public Vector3Data()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4BAE90", Offset = "0x4B9890", VA = "0x1804BAE90")]
		[DebuggerNonUserCode]
		public Vector3Data(Vector3Data other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x1D689F0", Offset = "0x1D673F0", VA = "0x181D689F0", Slot = "9")]
		[DebuggerNonUserCode]
		public Vector3Data Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1D68A60", Offset = "0x1D67460", VA = "0x181D68A60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x4BA9A0", Offset = "0x4B93A0", VA = "0x1804BA9A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(Vector3Data other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x4BAAD0", Offset = "0x4B94D0", VA = "0x1804BAAD0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1D68AF0", Offset = "0x1D674F0", VA = "0x181D68AF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x4BAD10", Offset = "0x4B9710", VA = "0x1804BAD10", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8F0", Offset = "0x4B92F0", VA = "0x1804BA8F0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x4BAC30", Offset = "0x4B9630", VA = "0x1804BAC30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5D180", Offset = "0x1D5BB80", VA = "0x181D5D180")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5D100", Offset = "0x1D5BB00", VA = "0x181D5D100")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5D1E0", Offset = "0x1D5BBE0", VA = "0x181D5D1E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x452340", Offset = "0x450D40", VA = "0x180452340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x452620", Offset = "0x451020", VA = "0x180452620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[DebuggerNonUserCode]
		public float X
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x452610", Offset = "0x451010", VA = "0x180452610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x452630", Offset = "0x451030", VA = "0x180452630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[DebuggerNonUserCode]
		public float Y
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8A0", Offset = "0x3AE2A0", VA = "0x1803AF8A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x3AF890", Offset = "0x3AE290", VA = "0x1803AF890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		[DebuggerNonUserCode]
		public float Z
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x3946F0", Offset = "0x3930F0", VA = "0x1803946F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x394790", Offset = "0x393190", VA = "0x180394790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		[DebuggerNonUserCode]
		public QuaternionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x4D6130", Offset = "0x4D4B30", VA = "0x1804D6130")]
		[DebuggerNonUserCode]
		public QuaternionData(QuaternionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CEC0", Offset = "0x1D5B8C0", VA = "0x181D5CEC0", Slot = "9")]
		[DebuggerNonUserCode]
		public QuaternionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CF40", Offset = "0x1D5B940", VA = "0x181D5CF40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xD9CC20", Offset = "0xD9B620", VA = "0x180D9CC20", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(QuaternionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xD9CD70", Offset = "0xD9B770", VA = "0x180D9CD70", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CFE0", Offset = "0x1D5B9E0", VA = "0x181D5CFE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xD9D010", Offset = "0xD9BA10", VA = "0x180D9D010", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xD9CB50", Offset = "0xD9B550", VA = "0x180D9CB50", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xD9CF00", Offset = "0xD9B900", VA = "0x180D9CF00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D0EA0", Offset = "0x18CF8A0", VA = "0x1818D0EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D0DD0", Offset = "0x18CF7D0", VA = "0x1818D0DD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D0F00", Offset = "0x18CF900", VA = "0x1818D0F00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x18D1010", Offset = "0x18CFA10", VA = "0x1818D1010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[DebuggerNonUserCode]
		public Vector3Data LocalPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[DebuggerNonUserCode]
		public QuaternionData LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x18D0D70", Offset = "0x18CF770", VA = "0x1818D0D70")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x18D0CB0", Offset = "0x18CF6B0", VA = "0x1818D0CB0")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData(CircuitObjectTransformData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x18D0660", Offset = "0x18CF060", VA = "0x1818D0660", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x18D0820", Offset = "0x18CF220", VA = "0x1818D0820", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x18D0750", Offset = "0x18CF150", VA = "0x1818D0750", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitObjectTransformData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x18D0930", Offset = "0x18CF330", VA = "0x1818D0930", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x18D0AE0", Offset = "0x18CF4E0", VA = "0x1818D0AE0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x18D0B40", Offset = "0x18CF540", VA = "0x1818D0B40", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x18D0560", Offset = "0x18CEF60", VA = "0x1818D0560", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x18D09C0", Offset = "0x18CF3C0", VA = "0x1818D09C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D16B0", Offset = "0x18D00B0", VA = "0x1818D16B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x18D1060", Offset = "0x18CFA60", VA = "0x1818D1060")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D1F60", Offset = "0x18D0960", VA = "0x1818D1F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D1E90", Offset = "0x18D0890", VA = "0x1818D1E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D1FC0", Offset = "0x18D09C0", VA = "0x1818D1FC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[DebuggerNonUserCode]
		public bool BackingBool
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x5212C0", Offset = "0x51FCC0", VA = "0x1805212C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x521470", Offset = "0x51FE70", VA = "0x180521470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[DebuggerNonUserCode]
		public int BackingInt
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x391230", Offset = "0x38FC30", VA = "0x180391230")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x391350", Offset = "0x38FD50", VA = "0x180391350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[DebuggerNonUserCode]
		public float BackingFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x3946F0", Offset = "0x3930F0", VA = "0x1803946F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x394790", Offset = "0x393190", VA = "0x180394790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[DebuggerNonUserCode]
		public string BackingString
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x18D20C0", Offset = "0x18D0AC0", VA = "0x1818D20C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x18D1DD0", Offset = "0x18D07D0", VA = "0x1818D1DD0")]
		[DebuggerNonUserCode]
		public CircuitSignalData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x18D1E10", Offset = "0x18D0810", VA = "0x1818D1E10")]
		[DebuggerNonUserCode]
		public CircuitSignalData(CircuitSignalData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x18D1820", Offset = "0x18D0220", VA = "0x1818D1820", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitSignalData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x18D1930", Offset = "0x18D0330", VA = "0x1818D1930", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x18D18D0", Offset = "0x18D02D0", VA = "0x1818D18D0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitSignalData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x18D19E0", Offset = "0x18D03E0", VA = "0x1818D19E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x18D1BA0", Offset = "0x18D05A0", VA = "0x1818D1BA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x18D1C00", Offset = "0x18D0600", VA = "0x1818D1C00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x18D1710", Offset = "0x18D0110", VA = "0x1818D1710", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x18D1AD0", Offset = "0x18D04D0", VA = "0x1818D1AD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C7A50", Offset = "0x18C6450", VA = "0x1818C7A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x18C6E80", Offset = "0x18C5880", VA = "0x1818C6E80")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C8BB0", Offset = "0x18C75B0", VA = "0x1818C8BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C8AE0", Offset = "0x18C74E0", VA = "0x1818C8AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C8C10", Offset = "0x18C7610", VA = "0x1818C8C10", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x18C8D10", Offset = "0x18C7710", VA = "0x1818C8D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[DebuggerNonUserCode]
		public ByteString ContextTemplateId
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x18C8D60", Offset = "0x18C7760", VA = "0x1818C8D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[DebuggerNonUserCode]
		public CircuitSerializationVersion SerializationVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x391370", Offset = "0x38FD70", VA = "0x180391370")]
			get
			{
				return default(CircuitSerializationVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x391260", Offset = "0x38FC60", VA = "0x180391260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[DebuggerNonUserCode]
		public EventBusData EventBusData
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x391070", Offset = "0x38FA70", VA = "0x180391070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitNodeData> NodeDatas
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x3972D0", Offset = "0x395CD0", VA = "0x1803972D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3972E0", Offset = "0x395CE0", VA = "0x1803972E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CDC00", Offset = "0x3CC600", VA = "0x1803CDC00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x906880", Offset = "0x905280", VA = "0x180906880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x18C8A20", Offset = "0x18C7420", VA = "0x1818C8A20")]
		[DebuggerNonUserCode]
		public CircuitContextData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x18C88A0", Offset = "0x18C72A0", VA = "0x1818C88A0")]
		[DebuggerNonUserCode]
		public CircuitContextData(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x18C7CA0", Offset = "0x18C66A0", VA = "0x1818C7CA0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x18C7E40", Offset = "0x18C6840", VA = "0x1818C7E40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x18C7D00", Offset = "0x18C6700", VA = "0x1818C7D00", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x18C7FB0", Offset = "0x18C69B0", VA = "0x1818C7FB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x18C84B0", Offset = "0x18C6EB0", VA = "0x1818C84B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x18C8510", Offset = "0x18C6F10", VA = "0x1818C8510", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x18C7AB0", Offset = "0x18C64B0", VA = "0x1818C7AB0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x18C82F0", Offset = "0x18C6CF0", VA = "0x1818C82F0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CircuitContextData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x18C80F0", Offset = "0x18C6AF0", VA = "0x1818C80F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D8580", Offset = "0x18D6F80", VA = "0x1818D8580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x18D6840", Offset = "0x18D5240", VA = "0x1818D6840")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D8DE0", Offset = "0x18D77E0", VA = "0x1818D8DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D8D10", Offset = "0x18D7710", VA = "0x1818D8D10")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D8E40", Offset = "0x18D7840", VA = "0x1818D8E40", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x18D8C00", Offset = "0x18D7600", VA = "0x1818D8C00")]
		[DebuggerNonUserCode]
		public EventBusData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x18D8C60", Offset = "0x18D7660", VA = "0x1818D8C60")]
		[DebuggerNonUserCode]
		public EventBusData(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x18D8660", Offset = "0x18D7060", VA = "0x1818D8660", Slot = "9")]
		[DebuggerNonUserCode]
		public EventBusData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x18D8740", Offset = "0x18D7140", VA = "0x1818D8740", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x18D8810", Offset = "0x18D7210", VA = "0x1818D8810", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventBusData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB50", Offset = "0x3ED550", VA = "0x1803EEB50", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x18D89B0", Offset = "0x18D73B0", VA = "0x1818D89B0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x18D8A10", Offset = "0x18D7410", VA = "0x1818D8A10", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x18D85E0", Offset = "0x18D6FE0", VA = "0x1818D85E0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x18D8950", Offset = "0x18D7350", VA = "0x1818D8950", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(EventBusData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x18D8890", Offset = "0x18D7290", VA = "0x1818D8890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CC3A0", Offset = "0x18CADA0", VA = "0x1818CC3A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CC2D0", Offset = "0x18CACD0", VA = "0x1818CC2D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CC400", Offset = "0x18CAE00", VA = "0x1818CC400", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x38FA50", Offset = "0x38E450", VA = "0x18038FA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		[DebuggerNonUserCode]
		public CircuitObjectTransformData TransformData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		[DebuggerNonUserCode]
		public InventionPieceData InventionData
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x18CC1B0", Offset = "0x18CABB0", VA = "0x1818CC1B0")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData(CircuitEventObjectData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x18CBBD0", Offset = "0x18CA5D0", VA = "0x1818CBBD0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventObjectData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x18CBD10", Offset = "0x18CA710", VA = "0x1818CBD10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x18CBDD0", Offset = "0x18CA7D0", VA = "0x1818CBDD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventObjectData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x18CBE40", Offset = "0x18CA840", VA = "0x1818CBE40", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x18CBFF0", Offset = "0x18CA9F0", VA = "0x1818CBFF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x18CC050", Offset = "0x18CAA50", VA = "0x1818CC050", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x18CBAE0", Offset = "0x18CA4E0", VA = "0x1818CBAE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x18CBEC0", Offset = "0x18CA8C0", VA = "0x1818CBEC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CAEC0", Offset = "0x18C98C0", VA = "0x1818CAEC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CADF0", Offset = "0x18C97F0", VA = "0x1818CADF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CAF20", Offset = "0x18C9920", VA = "0x1818CAF20", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x18CB030", Offset = "0x18C9A30", VA = "0x1818CB030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		[DebuggerNonUserCode]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x18CB080", Offset = "0x18C9A80", VA = "0x1818CB080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitEventProperty> EventProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x18CAD50", Offset = "0x18C9750", VA = "0x1818CAD50")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x18CACD0", Offset = "0x18C96D0", VA = "0x1818CACD0")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData(CircuitEventDefinitionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x18CA590", Offset = "0x18C8F90", VA = "0x1818CA590", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventDefinitionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x18CA630", Offset = "0x18C9030", VA = "0x1818CA630", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x18CA750", Offset = "0x18C9150", VA = "0x1818CA750", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventDefinitionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x18CA830", Offset = "0x18C9230", VA = "0x1818CA830", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x18CAA00", Offset = "0x18C9400", VA = "0x1818CAA00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x18CAA60", Offset = "0x18C9460", VA = "0x1818CAA60", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x18CA460", Offset = "0x18C8E60", VA = "0x1818CA460", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x18CA8E0", Offset = "0x18C92E0", VA = "0x1818CA8E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CCC80", Offset = "0x18CB680", VA = "0x1818CCC80")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CCBB0", Offset = "0x18CB5B0", VA = "0x1818CCBB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CCCE0", Offset = "0x18CB6E0", VA = "0x1818CCCE0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x18CCDF0", Offset = "0x18CB7F0", VA = "0x1818CCDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x18CCAB0", Offset = "0x18CB4B0", VA = "0x1818CCAB0")]
		[DebuggerNonUserCode]
		public CircuitEventProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x18CCAF0", Offset = "0x18CB4F0", VA = "0x1818CCAF0")]
		[DebuggerNonUserCode]
		public CircuitEventProperty(CircuitEventProperty other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x18CC5D0", Offset = "0x18CAFD0", VA = "0x1818CC5D0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventProperty Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x18CC710", Offset = "0x18CB110", VA = "0x1818CC710", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x18CC6B0", Offset = "0x18CB0B0", VA = "0x1818CC6B0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventProperty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x18CC7C0", Offset = "0x18CB1C0", VA = "0x1818CC7C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x18CC910", Offset = "0x18CB310", VA = "0x1818CC910", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x18CC970", Offset = "0x18CB370", VA = "0x1818CC970", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x18CC510", Offset = "0x18CAF10", VA = "0x1818CC510", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x18CC840", Offset = "0x18CB240", VA = "0x1818CC840", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DA150", Offset = "0x18D8B50", VA = "0x1818DA150")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DA080", Offset = "0x18D8A80", VA = "0x1818DA080")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DA1B0", Offset = "0x18D8BB0", VA = "0x1818DA1B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x18DA310", Offset = "0x18D8D10", VA = "0x1818DA310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		[DebuggerNonUserCode]
		public ByteString EventDefinitionId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x18DA2C0", Offset = "0x18D8CC0", VA = "0x1818DA2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x18DA010", Offset = "0x18D8A10", VA = "0x1818DA010")]
		[DebuggerNonUserCode]
		public EventRegistrationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x18D9F70", Offset = "0x18D8970", VA = "0x1818D9F70")]
		[DebuggerNonUserCode]
		public EventRegistrationData(EventRegistrationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x18D99E0", Offset = "0x18D83E0", VA = "0x1818D99E0", Slot = "9")]
		[DebuggerNonUserCode]
		public EventRegistrationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x18D9AA0", Offset = "0x18D84A0", VA = "0x1818D9AA0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x18D9BD0", Offset = "0x18D85D0", VA = "0x1818D9BD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventRegistrationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x18D9CB0", Offset = "0x18D86B0", VA = "0x1818D9CB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x18D9DC0", Offset = "0x18D87C0", VA = "0x1818D9DC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x18D9E20", Offset = "0x18D8820", VA = "0x1818D9E20", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x18D9910", Offset = "0x18D8310", VA = "0x1818D9910", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x18D9D40", Offset = "0x18D8740", VA = "0x1818D9D40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D60B20", Offset = "0x1D5F520", VA = "0x181D60B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D60AA0", Offset = "0x1D5F4A0", VA = "0x181D60AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D60B80", Offset = "0x1D5F580", VA = "0x181D60B80", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x1D60C40", Offset = "0x1D5F640", VA = "0x181D60C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		[DebuggerNonUserCode]
		public RepeatedField<EventDataKeyValuePair> Datas
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1D60A10", Offset = "0x1D5F410", VA = "0x181D60A10")]
		[DebuggerNonUserCode]
		public SynchronizedEventData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1D609A0", Offset = "0x1D5F3A0", VA = "0x181D609A0")]
		[DebuggerNonUserCode]
		public SynchronizedEventData(SynchronizedEventData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1D60370", Offset = "0x1D5ED70", VA = "0x181D60370", Slot = "9")]
		[DebuggerNonUserCode]
		public SynchronizedEventData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D60410", Offset = "0x1D5EE10", VA = "0x181D60410", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1D60520", Offset = "0x1D5EF20", VA = "0x181D60520", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SynchronizedEventData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1D605E0", Offset = "0x1D5EFE0", VA = "0x181D605E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1D60760", Offset = "0x1D5F160", VA = "0x181D60760", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1D607C0", Offset = "0x1D5F1C0", VA = "0x181D607C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1D60290", Offset = "0x1D5EC90", VA = "0x181D60290", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1D60660", Offset = "0x1D5F060", VA = "0x181D60660", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D9700", Offset = "0x18D8100", VA = "0x1818D9700")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D9630", Offset = "0x18D8030", VA = "0x1818D9630")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D9760", Offset = "0x18D8160", VA = "0x1818D9760", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x18D9870", Offset = "0x18D8270", VA = "0x1818D9870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		[DebuggerNonUserCode]
		public ByteString Value
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x18D98C0", Offset = "0x18D82C0", VA = "0x1818D98C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x18D95C0", Offset = "0x18D7FC0", VA = "0x1818D95C0")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x18D9520", Offset = "0x18D7F20", VA = "0x1818D9520")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair(EventDataKeyValuePair other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x18D9010", Offset = "0x18D7A10", VA = "0x1818D9010", Slot = "9")]
		[DebuggerNonUserCode]
		public EventDataKeyValuePair Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x18D9170", Offset = "0x18D7B70", VA = "0x1818D9170", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x18D90D0", Offset = "0x18D7AD0", VA = "0x1818D90D0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(EventDataKeyValuePair other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x18D9260", Offset = "0x18D7C60", VA = "0x1818D9260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x18D9370", Offset = "0x18D7D70", VA = "0x1818D9370", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x18D93D0", Offset = "0x18D7DD0", VA = "0x1818D93D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x18D8F40", Offset = "0x18D7940", VA = "0x1818D8F40", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x18D92F0", Offset = "0x18D7CF0", VA = "0x1818D92F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CB920", Offset = "0x18CA320", VA = "0x1818CB920")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CB850", Offset = "0x18CA250", VA = "0x1818CB850")]
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
			[Cpp2IlInjected.Address(RVA = "0x18CB980", Offset = "0x18CA380", VA = "0x1818CB980", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[DebuggerNonUserCode]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x18CBA90", Offset = "0x18CA490", VA = "0x1818CBA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[DebuggerNonUserCode]
		public CircuitTypeData PropertyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x18CB810", Offset = "0x18CA210", VA = "0x1818CB810")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x18CB750", Offset = "0x18CA150", VA = "0x1818CB750")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData(CircuitEventModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x18CB1D0", Offset = "0x18C9BD0", VA = "0x1818CB1D0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitEventModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x18CB330", Offset = "0x18C9D30", VA = "0x1818CB330", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x18CB2C0", Offset = "0x18C9CC0", VA = "0x1818CB2C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitEventModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x18CB3F0", Offset = "0x18C9DF0", VA = "0x1818CB3F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x18CB580", Offset = "0x18C9F80", VA = "0x1818CB580", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x18CB5E0", Offset = "0x18C9FE0", VA = "0x1818CB5E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x18CB0D0", Offset = "0x18C9AD0", VA = "0x1818CB0D0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x18CB490", Offset = "0x18C9E90", VA = "0x1818CB490", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D4FED0", Offset = "0x1D4E8D0", VA = "0x181D4FED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1D4F8E0", Offset = "0x1D4E2E0", VA = "0x181D4F8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D50650", Offset = "0x1D4F050", VA = "0x181D50650")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D50580", Offset = "0x1D4EF80", VA = "0x181D50580")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D506B0", Offset = "0x1D4F0B0", VA = "0x181D506B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x1D507B0", Offset = "0x1D4F1B0", VA = "0x181D507B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		[DebuggerNonUserCode]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		[DebuggerNonUserCode]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x391370", Offset = "0x38FD70", VA = "0x180391370")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x391260", Offset = "0x38FC60", VA = "0x180391260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		[DebuggerNonUserCode]
		public bool OriginallyFromOtherInvention
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x520670", Offset = "0x51F070", VA = "0x180520670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x5208D0", Offset = "0x51F2D0", VA = "0x1805208D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x1D50480", Offset = "0x1D4EE80", VA = "0x181D50480")]
		[DebuggerNonUserCode]
		public InventionPieceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1D504E0", Offset = "0x1D4EEE0", VA = "0x181D504E0")]
		[DebuggerNonUserCode]
		public InventionPieceData(InventionPieceData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x1D50030", Offset = "0x1D4EA30", VA = "0x181D50030", Slot = "9")]
		[DebuggerNonUserCode]
		public InventionPieceData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1D501B0", Offset = "0x1D4EBB0", VA = "0x181D501B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x1D500F0", Offset = "0x1D4EAF0", VA = "0x181D500F0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(InventionPieceData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xB21E60", Offset = "0xB20860", VA = "0x180B21E60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1D50360", Offset = "0x1D4ED60", VA = "0x181D50360", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0xB221B0", Offset = "0xB20BB0", VA = "0x180B221B0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1D4FF30", Offset = "0x1D4E930", VA = "0x181D4FF30", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1D502B0", Offset = "0x1D4ECB0", VA = "0x181D502B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C9550", Offset = "0x18C7F50", VA = "0x1818C9550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x18C8DB0", Offset = "0x18C77B0", VA = "0x1818C8DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C9EC0", Offset = "0x18C88C0", VA = "0x1818C9EC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C9DF0", Offset = "0x18C87F0", VA = "0x1818C9DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C9F20", Offset = "0x18C8920", VA = "0x1818C9F20", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		[DebuggerNonUserCode]
		public bool IsInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x5212C0", Offset = "0x51FCC0", VA = "0x1805212C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x521470", Offset = "0x51FE70", VA = "0x180521470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		[DebuggerNonUserCode]
		public string GroupName
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x18CA070", Offset = "0x18C8A70", VA = "0x1818CA070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		[DebuggerNonUserCode]
		public ByteString GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x18CA020", Offset = "0x18C8A20", VA = "0x1818CA020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x18C9CE0", Offset = "0x18C86E0", VA = "0x1818C9CE0")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x18C9D50", Offset = "0x18C8750", VA = "0x1818C9D50")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData(CircuitContextNodeOperationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x18C96C0", Offset = "0x18C80C0", VA = "0x1818C96C0", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitContextNodeOperationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x18C9840", Offset = "0x18C8240", VA = "0x1818C9840", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x18C9790", Offset = "0x18C8190", VA = "0x1818C9790", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitContextNodeOperationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x18C9940", Offset = "0x18C8340", VA = "0x1818C9940", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x18C9AD0", Offset = "0x18C84D0", VA = "0x1818C9AD0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x18C9B30", Offset = "0x18C8530", VA = "0x1818C9B30", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x18C95B0", Offset = "0x18C7FB0", VA = "0x1818C95B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x18C9A10", Offset = "0x18C8410", VA = "0x1818C9A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D521E0", Offset = "0x1D50BE0", VA = "0x181D521E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x1D50D00", Offset = "0x1D4F700", VA = "0x181D50D00")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D52DA0", Offset = "0x1D517A0", VA = "0x181D52DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D52CD0", Offset = "0x1D516D0", VA = "0x181D52CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D52E00", Offset = "0x1D51800", VA = "0x181D52E00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x1D52F00", Offset = "0x1D51900", VA = "0x181D52F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		[DebuggerNonUserCode]
		public ByteString ObjectId
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x1D52FA0", Offset = "0x1D519A0", VA = "0x181D52FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		[DebuggerNonUserCode]
		public CircuitObjectType ModifiedObjectType
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x391370", Offset = "0x38FD70", VA = "0x180391370")]
			get
			{
				return default(CircuitObjectType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x391260", Offset = "0x38FC60", VA = "0x180391260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		[DebuggerNonUserCode]
		public ByteString ModificationHandlerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x1D52F50", Offset = "0x1D51950", VA = "0x181D52F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[DebuggerNonUserCode]
		public ByteString Payload
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x3972D0", Offset = "0x395CD0", VA = "0x1803972D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x1D52FF0", Offset = "0x1D519F0", VA = "0x181D52FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x1D52C50", Offset = "0x1D51650", VA = "0x181D52C50")]
		[DebuggerNonUserCode]
		public ModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1D52BF0", Offset = "0x1D515F0", VA = "0x181D52BF0")]
		[DebuggerNonUserCode]
		public ModificationData(ModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x1D523E0", Offset = "0x1D50DE0", VA = "0x181D523E0", Slot = "9")]
		[DebuggerNonUserCode]
		public ModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1D52470", Offset = "0x1D50E70", VA = "0x181D52470", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1D52620", Offset = "0x1D51020", VA = "0x181D52620", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1D52770", Offset = "0x1D51170", VA = "0x181D52770", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1D52990", Offset = "0x1D51390", VA = "0x181D52990", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1D529F0", Offset = "0x1D513F0", VA = "0x181D529F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1D52240", Offset = "0x1D50C40", VA = "0x181D52240", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1D52890", Offset = "0x1D51290", VA = "0x181D52890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D578E0", Offset = "0x1D562E0", VA = "0x181D578E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D57810", Offset = "0x1D56210", VA = "0x181D57810")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D57940", Offset = "0x1D56340", VA = "0x181D57940", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x1D57A50", Offset = "0x1D56450", VA = "0x181D57A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[DebuggerNonUserCode]
		public ByteString NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x1D57AA0", Offset = "0x1D564A0", VA = "0x181D57AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x3E8920", Offset = "0x3E7320", VA = "0x1803E8920")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x3E8930", Offset = "0x3E7330", VA = "0x1803E8930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[DebuggerNonUserCode]
		public ByteString PortId
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x1D57AF0", Offset = "0x1D564F0", VA = "0x181D57AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x1D57740", Offset = "0x1D56140", VA = "0x181D57740")]
		[DebuggerNonUserCode]
		public PortAddress()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1D577C0", Offset = "0x1D561C0", VA = "0x181D577C0")]
		[DebuggerNonUserCode]
		public PortAddress(PortAddress other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1D57060", Offset = "0x1D55A60", VA = "0x181D57060", Slot = "9")]
		[DebuggerNonUserCode]
		public PortAddress Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1D570E0", Offset = "0x1D55AE0", VA = "0x181D570E0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1D57250", Offset = "0x1D55C50", VA = "0x181D57250", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortAddress other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x1D57370", Offset = "0x1D55D70", VA = "0x181D57370", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x1D57520", Offset = "0x1D55F20", VA = "0x181D57520", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1D57580", Offset = "0x1D55F80", VA = "0x181D57580", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1D56F30", Offset = "0x1D55930", VA = "0x181D56F30", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x1D57450", Offset = "0x1D55E50", VA = "0x181D57450", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5C450", Offset = "0x1D5AE50", VA = "0x181D5C450")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5C380", Offset = "0x1D5AD80", VA = "0x181D5C380")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5C4B0", Offset = "0x1D5AEB0", VA = "0x181D5C4B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(Types.OperationTypes);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[DebuggerNonUserCode]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x5212C0", Offset = "0x51FCC0", VA = "0x1805212C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x521470", Offset = "0x51FE70", VA = "0x180521470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[DebuggerNonUserCode]
		public ByteString PortGroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x1D5C5C0", Offset = "0x1D5AFC0", VA = "0x181D5C5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		[DebuggerNonUserCode]
		public NodePortData PortData
		{
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C1C0", Offset = "0x1D5ABC0", VA = "0x181D5C1C0")]
		[DebuggerNonUserCode]
		public PortModificationData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C220", Offset = "0x1D5AC20", VA = "0x181D5C220")]
		[DebuggerNonUserCode]
		public PortModificationData(PortModificationData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D5BA80", Offset = "0x1D5A480", VA = "0x181D5BA80", Slot = "9")]
		[DebuggerNonUserCode]
		public PortModificationData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D5BCE0", Offset = "0x1D5A6E0", VA = "0x181D5BCE0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1D5BC10", Offset = "0x1D5A610", VA = "0x181D5BC10", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortModificationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D5BDF0", Offset = "0x1D5A7F0", VA = "0x181D5BDF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D5BFC0", Offset = "0x1D5A9C0", VA = "0x181D5BFC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C020", Offset = "0x1D5AA20", VA = "0x181D5C020", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B980", Offset = "0x1D5A380", VA = "0x181D5B980", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x1D5BEB0", Offset = "0x1D5A8B0", VA = "0x181D5BEB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D59990", Offset = "0x1D58390", VA = "0x181D59990")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D598C0", Offset = "0x1D582C0", VA = "0x181D598C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D599F0", Offset = "0x1D583F0", VA = "0x181D599F0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x1D59B00", Offset = "0x1D58500", VA = "0x181D59B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D597B0", Offset = "0x1D581B0", VA = "0x181D597B0")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D59810", Offset = "0x1D58210", VA = "0x181D59810")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData(PortDefaultValuePayloadData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D59340", Offset = "0x1D57D40", VA = "0x181D59340", Slot = "9")]
		[DebuggerNonUserCode]
		public PortDefaultValuePayloadData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D59410", Offset = "0x1D57E10", VA = "0x181D59410", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D59510", Offset = "0x1D57F10", VA = "0x181D59510", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortDefaultValuePayloadData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x18D6180", Offset = "0x18D4B80", VA = "0x1818D6180", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D59690", Offset = "0x1D58090", VA = "0x181D59690", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x18D6330", Offset = "0x18D4D30", VA = "0x1818D6330", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D59280", Offset = "0x1D57C80", VA = "0x181D59280", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x1D595C0", Offset = "0x1D57FC0", VA = "0x181D595C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D53450", Offset = "0x1D51E50", VA = "0x181D53450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D53040", Offset = "0x1D51A40", VA = "0x181D53040")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D53F40", Offset = "0x1D52940", VA = "0x181D53F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D53E70", Offset = "0x1D52870", VA = "0x181D53E70")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D53FA0", Offset = "0x1D529A0", VA = "0x181D53FA0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x1D54140", Offset = "0x1D52B40", VA = "0x181D54140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		[DebuggerNonUserCode]
		public ByteString SrcPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(RVA = "0x1D54190", Offset = "0x1D52B90", VA = "0x181D54190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		[DebuggerNonUserCode]
		public ByteString DstNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(RVA = "0x1D540A0", Offset = "0x1D52AA0", VA = "0x181D540A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		[DebuggerNonUserCode]
		public ByteString DstPortId
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0x1D540F0", Offset = "0x1D52AF0", VA = "0x181D540F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x1D53DF0", Offset = "0x1D527F0", VA = "0x181D53DF0")]
		[DebuggerNonUserCode]
		public NodeConnectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D53DA0", Offset = "0x1D527A0", VA = "0x181D53DA0")]
		[DebuggerNonUserCode]
		public NodeConnectionData(NodeConnectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D53620", Offset = "0x1D52020", VA = "0x181D53620", Slot = "9")]
		[DebuggerNonUserCode]
		public NodeConnectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D537F0", Offset = "0x1D521F0", VA = "0x181D537F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D536A0", Offset = "0x1D520A0", VA = "0x181D536A0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodeConnectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D53990", Offset = "0x1D52390", VA = "0x181D53990", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x1D53B70", Offset = "0x1D52570", VA = "0x181D53B70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D53BD0", Offset = "0x1D525D0", VA = "0x181D53BD0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x1D534B0", Offset = "0x1D51EB0", VA = "0x181D534B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x1D53A90", Offset = "0x1D52490", VA = "0x181D53A90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D54850", Offset = "0x1D53250", VA = "0x181D54850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x1D541E0", Offset = "0x1D52BE0", VA = "0x181D541E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D55220", Offset = "0x1D53C20", VA = "0x181D55220")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D55150", Offset = "0x1D53B50", VA = "0x181D55150")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D55280", Offset = "0x1D53C80", VA = "0x181D55280", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x1D55380", Offset = "0x1D53D80", VA = "0x181D55380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		[DebuggerNonUserCode]
		public string PortName
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x1D553D0", Offset = "0x1D53DD0", VA = "0x181D553D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		[DebuggerNonUserCode]
		public CircuitTypeData GenericPortType
		{
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1D55020", Offset = "0x1D53A20", VA = "0x181D55020")]
		[DebuggerNonUserCode]
		public NodePortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x1D55090", Offset = "0x1D53A90", VA = "0x181D55090")]
		[DebuggerNonUserCode]
		public NodePortData(NodePortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x1D549C0", Offset = "0x1D533C0", VA = "0x181D549C0", Slot = "9")]
		[DebuggerNonUserCode]
		public NodePortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x1D54AB0", Offset = "0x1D534B0", VA = "0x181D54AB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1D54BC0", Offset = "0x1D535C0", VA = "0x181D54BC0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NodePortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x1D54C90", Offset = "0x1D53690", VA = "0x181D54C90", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x1D54E40", Offset = "0x1D53840", VA = "0x181D54E40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x1D54EA0", Offset = "0x1D538A0", VA = "0x181D54EA0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x1D548B0", Offset = "0x1D532B0", VA = "0x181D548B0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x1D54D40", Offset = "0x1D53740", VA = "0x181D54D40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D55700", Offset = "0x1D54100", VA = "0x181D55700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x1D55420", Offset = "0x1D53E20", VA = "0x181D55420")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D55D30", Offset = "0x1D54730", VA = "0x181D55D30")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D55C60", Offset = "0x1D54660", VA = "0x181D55C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D55D90", Offset = "0x1D54790", VA = "0x181D55D90", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x1D55E90", Offset = "0x1D54890", VA = "0x181D55E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x1D55C00", Offset = "0x1D54600", VA = "0x181D55C00")]
		[DebuggerNonUserCode]
		public NullableBytes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1D55B80", Offset = "0x1D54580", VA = "0x181D55B80")]
		[DebuggerNonUserCode]
		public NullableBytes(NullableBytes other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x1D557E0", Offset = "0x1D541E0", VA = "0x181D557E0", Slot = "9")]
		[DebuggerNonUserCode]
		public NullableBytes Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1D55920", Offset = "0x1D54320", VA = "0x181D55920", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x1D55890", Offset = "0x1D54290", VA = "0x181D55890", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(NullableBytes other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x906280", Offset = "0x904C80", VA = "0x180906280", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x1D55A60", Offset = "0x1D54460", VA = "0x181D55A60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x9064F0", Offset = "0x904EF0", VA = "0x1809064F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1D55760", Offset = "0x1D54160", VA = "0x181D55760", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x1D55A00", Offset = "0x1D54400", VA = "0x181D55A00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D585A0", Offset = "0x1D56FA0", VA = "0x181D585A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x1D57B40", Offset = "0x1D56540", VA = "0x181D57B40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D59120", Offset = "0x1D57B20", VA = "0x181D59120")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D59050", Offset = "0x1D57A50", VA = "0x181D59050")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D59180", Offset = "0x1D57B80", VA = "0x181D59180", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x1D58FA0", Offset = "0x1D579A0", VA = "0x181D58FA0")]
		[DebuggerNonUserCode]
		public PortCollectionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x1D58F00", Offset = "0x1D57900", VA = "0x181D58F00")]
		[DebuggerNonUserCode]
		public PortCollectionData(PortCollectionData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x1D586F0", Offset = "0x1D570F0", VA = "0x181D586F0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortCollectionData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x1D587C0", Offset = "0x1D571C0", VA = "0x181D587C0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1D588D0", Offset = "0x1D572D0", VA = "0x181D588D0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortCollectionData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x1D58980", Offset = "0x1D57380", VA = "0x181D58980", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x1D58BA0", Offset = "0x1D575A0", VA = "0x181D58BA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x1D58C00", Offset = "0x1D57600", VA = "0x181D58C00", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x1D58600", Offset = "0x1D57000", VA = "0x181D58600", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x1D58A10", Offset = "0x1D57410", VA = "0x181D58A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D6670", Offset = "0x18D5070", VA = "0x1818D6670")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D65F0", Offset = "0x18D4FF0", VA = "0x1818D65F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D66D0", Offset = "0x18D50D0", VA = "0x1818D66D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x18D6790", Offset = "0x18D5190", VA = "0x1818D6790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		[DebuggerNonUserCode]
		public CircuitSignalData DefaultValueData
		{
			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x18D6590", Offset = "0x18D4F90", VA = "0x1818D6590")]
		[DebuggerNonUserCode]
		public DefaultPortData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x18D6470", Offset = "0x18D4E70", VA = "0x1818D6470")]
		[DebuggerNonUserCode]
		public DefaultPortData(DefaultPortData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x18D5E80", Offset = "0x18D4880", VA = "0x1818D5E80", Slot = "9")]
		[DebuggerNonUserCode]
		public DefaultPortData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x18D6080", Offset = "0x18D4A80", VA = "0x1818D6080", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x18D5FD0", Offset = "0x18D49D0", VA = "0x1818D5FD0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(DefaultPortData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x18D6180", Offset = "0x18D4B80", VA = "0x1818D6180", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x18D62D0", Offset = "0x18D4CD0", VA = "0x1818D62D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x18D6330", Offset = "0x18D4D30", VA = "0x1818D6330", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x18D5DC0", Offset = "0x18D47C0", VA = "0x1818D5DC0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x18D6200", Offset = "0x18D4C00", VA = "0x1818D6200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5A720", Offset = "0x1D59120", VA = "0x181D5A720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x1D59B50", Offset = "0x1D58550", VA = "0x181D59B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5B6E0", Offset = "0x1D5A0E0", VA = "0x181D5B6E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5B610", Offset = "0x1D5A010", VA = "0x181D5B610")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5B740", Offset = "0x1D5A140", VA = "0x181D5B740", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x1D5B8E0", Offset = "0x1D5A2E0", VA = "0x181D5B8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		[DebuggerNonUserCode]
		public PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x391230", Offset = "0x38FC30", VA = "0x180391230")]
			get
			{
				return default(PortGroupType);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x391350", Offset = "0x38FD50", VA = "0x180391350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		[DebuggerNonUserCode]
		public RepeatedField<NodePortData> NodePortDatas
		{
			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
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
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x1D5B930", Offset = "0x1D5A330", VA = "0x181D5B930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		[DebuggerNonUserCode]
		public CircuitTypeData ElementPortType
		{
			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0x3972D0", Offset = "0x395CD0", VA = "0x1803972D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0x3AE380", Offset = "0x3ACD80", VA = "0x1803AE380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		[DebuggerNonUserCode]
		public uint NumberOfPorts
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x3AE1F0", Offset = "0x3ACBF0", VA = "0x1803AE1F0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x3AE200", Offset = "0x3ACC00", VA = "0x1803AE200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		[DebuggerNonUserCode]
		public string ElementName
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x3972C0", Offset = "0x395CC0", VA = "0x1803972C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x1D5B840", Offset = "0x1D5A240", VA = "0x181D5B840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		[DebuggerNonUserCode]
		public string ExecName
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x3D8600", Offset = "0x3D7000", VA = "0x1803D8600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x1D5B890", Offset = "0x1D5A290", VA = "0x181D5B890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B560", Offset = "0x1D59F60", VA = "0x181D5B560")]
		[DebuggerNonUserCode]
		public PortGroupData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B4B0", Offset = "0x1D59EB0", VA = "0x181D5B4B0")]
		[DebuggerNonUserCode]
		public PortGroupData(PortGroupData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1D5A9E0", Offset = "0x1D593E0", VA = "0x181D5A9E0", Slot = "9")]
		[DebuggerNonUserCode]
		public PortGroupData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x1D5AC00", Offset = "0x1D59600", VA = "0x181D5AC00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1D5AAC0", Offset = "0x1D594C0", VA = "0x181D5AAC0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PortGroupData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x1D5AD80", Offset = "0x1D59780", VA = "0x181D5AD80", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B0E0", Offset = "0x1D59AE0", VA = "0x181D5B0E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B140", Offset = "0x1D59B40", VA = "0x181D5B140", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5A780", Offset = "0x1D59180", VA = "0x181D5A780", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x1D5AEF0", Offset = "0x1D598F0", VA = "0x181D5AEF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5EF80", Offset = "0x1D5D980", VA = "0x181D5EF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EC30", Offset = "0x1D5D630", VA = "0x181D5EC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5F880", Offset = "0x1D5E280", VA = "0x181D5F880")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5F7B0", Offset = "0x1D5E1B0", VA = "0x181D5F7B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5F8E0", Offset = "0x1D5E2E0", VA = "0x181D5F8E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F6B0", Offset = "0x1D5E0B0", VA = "0x181D5F6B0")]
		[DebuggerNonUserCode]
		public SwitchNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F730", Offset = "0x1D5E130", VA = "0x181D5F730")]
		[DebuggerNonUserCode]
		public SwitchNodeData(SwitchNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F0A0", Offset = "0x1D5DAA0", VA = "0x181D5F0A0", Slot = "9")]
		[DebuggerNonUserCode]
		public SwitchNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F150", Offset = "0x1D5DB50", VA = "0x181D5F150", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F240", Offset = "0x1D5DC40", VA = "0x181D5F240", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(SwitchNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F2E0", Offset = "0x1D5DCE0", VA = "0x181D5F2E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F480", Offset = "0x1D5DE80", VA = "0x181D5F480", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F4E0", Offset = "0x1D5DEE0", VA = "0x181D5F4E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EFE0", Offset = "0x1D5D9E0", VA = "0x181D5EFE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F340", Offset = "0x1D5DD40", VA = "0x181D5F340", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D66060", Offset = "0x1D64A60", VA = "0x181D66060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x1D63650", Offset = "0x1D62050", VA = "0x181D63650")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C66D0", Offset = "0x18C50D0", VA = "0x1818C66D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C6650", Offset = "0x18C5050", VA = "0x1818C6650")]
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
			[Cpp2IlInjected.Address(RVA = "0x18C6730", Offset = "0x18C5130", VA = "0x1818C6730", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[DebuggerNonUserCode]
		public CircuitTypeData OriginalType
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameterAssignments
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x18C65F0", Offset = "0x18C4FF0", VA = "0x1818C65F0")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x18C6520", Offset = "0x18C4F20", VA = "0x1818C6520")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData(AppliedGenericTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x18C5E60", Offset = "0x18C4860", VA = "0x1818C5E60", Slot = "9")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x18C5F60", Offset = "0x18C4960", VA = "0x1818C5F60", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x18C6040", Offset = "0x18C4A40", VA = "0x1818C6040", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(AppliedGenericTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x18C60D0", Offset = "0x18C4AD0", VA = "0x1818C60D0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x18C6280", Offset = "0x18C4C80", VA = "0x1818C6280", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x18C62E0", Offset = "0x18C4CE0", VA = "0x1818C62E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x18C5D60", Offset = "0x18C4760", VA = "0x1818C5D60", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x18C6150", Offset = "0x18C4B50", VA = "0x1818C6150", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D5060", Offset = "0x18D3A60", VA = "0x1818D5060")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D4FE0", Offset = "0x18D39E0", VA = "0x1818D4FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D50C0", Offset = "0x18D3AC0", VA = "0x1818D50C0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[DebuggerNonUserCode]
		public int Kind
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x391250", Offset = "0x38FC50", VA = "0x180391250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x391270", Offset = "0x38FC70", VA = "0x180391270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[DebuggerNonUserCode]
		public AppliedGenericTypeData AppliedGenericType
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		[DebuggerNonUserCode]
		public ClassTypeData ClassType
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		[DebuggerNonUserCode]
		public FunctionTypeData FunctionType
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x391070", Offset = "0x38FA70", VA = "0x180391070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData TypeParameterReferenceType
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x3972D0", Offset = "0x395CD0", VA = "0x1803972D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x3AE380", Offset = "0x3ACD80", VA = "0x1803AE380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData TypeParameterType
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x3972E0", Offset = "0x395CE0", VA = "0x1803972E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x3D4F80", Offset = "0x3D3980", VA = "0x1803D4F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		[DebuggerNonUserCode]
		public CircuitTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x18D4CF0", Offset = "0x18D36F0", VA = "0x1818D4CF0")]
		[DebuggerNonUserCode]
		public CircuitTypeData(CircuitTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x18D4580", Offset = "0x18D2F80", VA = "0x1818D4580", Slot = "9")]
		[DebuggerNonUserCode]
		public CircuitTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x18D4690", Offset = "0x18D3090", VA = "0x1818D4690", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x18D45E0", Offset = "0x18D2FE0", VA = "0x1818D45E0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(CircuitTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x18D47A0", Offset = "0x18D31A0", VA = "0x1818D47A0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x18D4A80", Offset = "0x18D3480", VA = "0x1818D4A80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x18D4AE0", Offset = "0x18D34E0", VA = "0x1818D4AE0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x18D43C0", Offset = "0x18D2DC0", VA = "0x1818D43C0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x18D4890", Offset = "0x18D3290", VA = "0x1818D4890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D5CA0", Offset = "0x18D46A0", VA = "0x1818D5CA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D5C20", Offset = "0x18D4620", VA = "0x1818D5C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x18D5D00", Offset = "0x18D4700", VA = "0x1818D5D00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
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
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B9")]
			[Cpp2IlInjected.Address(RVA = "0x391070", Offset = "0x38FA70", VA = "0x180391070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x18D5AF0", Offset = "0x18D44F0", VA = "0x1818D5AF0")]
		[DebuggerNonUserCode]
		public ClassTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x18D5B70", Offset = "0x18D4570", VA = "0x1818D5B70")]
		[DebuggerNonUserCode]
		public ClassTypeData(ClassTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x18D52B0", Offset = "0x18D3CB0", VA = "0x1818D52B0", Slot = "9")]
		[DebuggerNonUserCode]
		public ClassTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x18D5390", Offset = "0x18D3D90", VA = "0x1818D5390", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x18D5490", Offset = "0x18D3E90", VA = "0x1818D5490", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ClassTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x18D5540", Offset = "0x18D3F40", VA = "0x1818D5540", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x18D5780", Offset = "0x18D4180", VA = "0x1818D5780", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x18D57E0", Offset = "0x18D41E0", VA = "0x1818D57E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x18D5180", Offset = "0x18D3B80", VA = "0x1818D5180", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x18D55F0", Offset = "0x18D3FF0", VA = "0x1818D55F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DAEC0", Offset = "0x18D98C0", VA = "0x1818DAEC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DAE40", Offset = "0x18D9840", VA = "0x1818DAE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DAF20", Offset = "0x18D9920", VA = "0x1818DAF20", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[DebuggerNonUserCode]
		public RepeatedField<CircuitTypeData> TypeParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
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
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x18DAD90", Offset = "0x18D9790", VA = "0x1818DAD90")]
		[DebuggerNonUserCode]
		public FunctionTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x18DACF0", Offset = "0x18D96F0", VA = "0x1818DACF0")]
		[DebuggerNonUserCode]
		public FunctionTypeData(FunctionTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x18DA480", Offset = "0x18D8E80", VA = "0x1818DA480", Slot = "9")]
		[DebuggerNonUserCode]
		public FunctionTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x18DA550", Offset = "0x18D8F50", VA = "0x1818DA550", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x18DA660", Offset = "0x18D9060", VA = "0x1818DA660", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(FunctionTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x18DA720", Offset = "0x18D9120", VA = "0x1818DA720", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x18DA980", Offset = "0x18D9380", VA = "0x1818DA980", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x18DA9E0", Offset = "0x18D93E0", VA = "0x1818DA9E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x18DA360", Offset = "0x18D8D60", VA = "0x1818DA360", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x18DA7D0", Offset = "0x18D91D0", VA = "0x1818DA7D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D563D0", Offset = "0x1D54DD0", VA = "0x181D563D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D56300", Offset = "0x1D54D00", VA = "0x181D56300")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D56430", Offset = "0x1D54E30", VA = "0x181D56430", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		[DebuggerNonUserCode]
		public ParameterData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x1D562A0", Offset = "0x1D54CA0", VA = "0x181D562A0")]
		[DebuggerNonUserCode]
		public ParameterData(ParameterData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D55FA0", Offset = "0x1D549A0", VA = "0x181D55FA0", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x1D56030", Offset = "0x1D54A30", VA = "0x181D56030", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xDFECE0", Offset = "0xDFD6E0", VA = "0x180DFECE0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xDFEE10", Offset = "0xDFD810", VA = "0x180DFEE10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x1D56180", Offset = "0x1D54B80", VA = "0x181D56180", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xDFF0C0", Offset = "0xDFDAC0", VA = "0x180DFF0C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x1D55EE0", Offset = "0x1D548E0", VA = "0x181D55EE0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x1D560C0", Offset = "0x1D54AC0", VA = "0x181D560C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D56C10", Offset = "0x1D55610", VA = "0x181D56C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D56B40", Offset = "0x1D55540", VA = "0x181D56B40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D56C70", Offset = "0x1D55670", VA = "0x181D56C70", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x1D56D80", Offset = "0x1D55780", VA = "0x181D56D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[DebuggerNonUserCode]
		public ParameterData Value
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x1D56A20", Offset = "0x1D55420", VA = "0x181D56A20")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x1D56A60", Offset = "0x1D55460", VA = "0x181D56A60")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData(ParameterWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x1D56640", Offset = "0x1D55040", VA = "0x181D56640", Slot = "9")]
		[DebuggerNonUserCode]
		public ParameterWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x1D56750", Offset = "0x1D55150", VA = "0x181D56750", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x18CB2C0", Offset = "0x18C9CC0", VA = "0x1818CB2C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ParameterWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x18CB3F0", Offset = "0x18C9DF0", VA = "0x1818CB3F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x1D56900", Offset = "0x1D55300", VA = "0x181D56900", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x18CB5E0", Offset = "0x18C9FE0", VA = "0x1818CB5E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x1D56540", Offset = "0x1D54F40", VA = "0x181D56540", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x1D56810", Offset = "0x1D55210", VA = "0x181D56810", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5CD50", Offset = "0x1D5B750", VA = "0x181D5CD50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5CC80", Offset = "0x1D5B680", VA = "0x181D5CC80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5CDB0", Offset = "0x1D5B7B0", VA = "0x181D5CDB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		[DebuggerNonUserCode]
		public bool Get
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x3E8920", Offset = "0x3E7320", VA = "0x1803E8920")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x3E8930", Offset = "0x3E7330", VA = "0x1803E8930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		[DebuggerNonUserCode]
		public bool Set
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x4D3CE0", Offset = "0x4D26E0", VA = "0x1804D3CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x4D3CF0", Offset = "0x4D26F0", VA = "0x1804D3CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		[DebuggerNonUserCode]
		public PropertyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CC20", Offset = "0x1D5B620", VA = "0x181D5CC20")]
		[DebuggerNonUserCode]
		public PropertyData(PropertyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C6D0", Offset = "0x1D5B0D0", VA = "0x181D5C6D0", Slot = "9")]
		[DebuggerNonUserCode]
		public PropertyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C760", Offset = "0x1D5B160", VA = "0x181D5C760", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C820", Offset = "0x1D5B220", VA = "0x181D5C820", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(PropertyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C890", Offset = "0x1D5B290", VA = "0x181D5C890", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CA30", Offset = "0x1D5B430", VA = "0x181D5CA30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CA90", Offset = "0x1D5B490", VA = "0x181D5CA90", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C610", Offset = "0x1D5B010", VA = "0x181D5C610", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C930", Offset = "0x1D5B330", VA = "0x181D5C930", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5D730", Offset = "0x1D5C130", VA = "0x181D5D730")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5D660", Offset = "0x1D5C060", VA = "0x181D5D660")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5D790", Offset = "0x1D5C190", VA = "0x181D5D790", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		[DebuggerNonUserCode]
		public CircuitTypeData Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x391220", Offset = "0x38FC20", VA = "0x180391220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
		[DebuggerNonUserCode]
		public ReturnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x1D562A0", Offset = "0x1D54CA0", VA = "0x181D562A0")]
		[DebuggerNonUserCode]
		public ReturnData(ReturnData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D360", Offset = "0x1D5BD60", VA = "0x181D5D360", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D3F0", Offset = "0x1D5BDF0", VA = "0x181D5D3F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xDFECE0", Offset = "0xDFD6E0", VA = "0x180DFECE0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xDFEE10", Offset = "0xDFD810", VA = "0x180DFEE10", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D540", Offset = "0x1D5BF40", VA = "0x181D5D540", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xDFF0C0", Offset = "0xDFDAC0", VA = "0x180DFF0C0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D2A0", Offset = "0x1D5BCA0", VA = "0x181D5D2A0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D480", Offset = "0x1D5BE80", VA = "0x181D5D480", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5DF70", Offset = "0x1D5C970", VA = "0x181D5DF70")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5DEA0", Offset = "0x1D5C8A0", VA = "0x181D5DEA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D5DFD0", Offset = "0x1D5C9D0", VA = "0x181D5DFD0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		[DebuggerNonUserCode]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x1D5E0E0", Offset = "0x1D5CAE0", VA = "0x181D5E0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[DebuggerNonUserCode]
		public ReturnData Value
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DD80", Offset = "0x1D5C780", VA = "0x181D5DD80")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DDC0", Offset = "0x1D5C7C0", VA = "0x181D5DDC0")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData(ReturnWithKeyData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D9A0", Offset = "0x1D5C3A0", VA = "0x181D5D9A0", Slot = "9")]
		[DebuggerNonUserCode]
		public ReturnWithKeyData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DAB0", Offset = "0x1D5C4B0", VA = "0x181D5DAB0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x18CB2C0", Offset = "0x18C9CC0", VA = "0x1818CB2C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(ReturnWithKeyData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x18CB3F0", Offset = "0x18C9DF0", VA = "0x1818CB3F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DC60", Offset = "0x1D5C660", VA = "0x181D5DC60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x18CB5E0", Offset = "0x18C9FE0", VA = "0x1818CB5E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D8A0", Offset = "0x1D5C2A0", VA = "0x181D5D8A0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DB70", Offset = "0x1D5C570", VA = "0x181D5DB70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D61CB0", Offset = "0x1D606B0", VA = "0x181D61CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D61BE0", Offset = "0x1D605E0", VA = "0x181D61BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D61D10", Offset = "0x1D60710", VA = "0x181D61D10", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x1D61E20", Offset = "0x1D60820", VA = "0x181D61E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x1D61BA0", Offset = "0x1D605A0", VA = "0x181D61BA0")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x1D61B30", Offset = "0x1D60530", VA = "0x181D61B30")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData(TypeParameterReferenceTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1D61880", Offset = "0x1D60280", VA = "0x181D61880", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterReferenceTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x1D61910", Offset = "0x1D60310", VA = "0x181D61910", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38E650", VA = "0x18038FC50", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterReferenceTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x38FDA0", Offset = "0x38E7A0", VA = "0x18038FDA0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x1D61A10", Offset = "0x1D60410", VA = "0x181D61A10", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x390040", Offset = "0x38EA40", VA = "0x180390040", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x1D617C0", Offset = "0x1D601C0", VA = "0x181D617C0", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x1D619A0", Offset = "0x1D603A0", VA = "0x181D619A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D624A0", Offset = "0x1D60EA0", VA = "0x181D624A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D623D0", Offset = "0x1D60DD0", VA = "0x181D623D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D62500", Offset = "0x1D60F00", VA = "0x181D62500", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FD90", Offset = "0x38E790", VA = "0x18038FD90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000668")]
			[Cpp2IlInjected.Address(RVA = "0x38FD20", Offset = "0x38E720", VA = "0x18038FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[DebuggerNonUserCode]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000669")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0x1D62610", Offset = "0x1D61010", VA = "0x181D62610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		[DebuggerNonUserCode]
		public CircuitTypeData Constraint
		{
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066C")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x1D62390", Offset = "0x1D60D90", VA = "0x181D62390")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x1D62300", Offset = "0x1D60D00", VA = "0x181D62300")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData(TypeParameterTypeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x1D61F70", Offset = "0x1D60970", VA = "0x181D61F70", Slot = "9")]
		[DebuggerNonUserCode]
		public TypeParameterTypeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x1D62030", Offset = "0x1D60A30", VA = "0x181D62030", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x18CB2C0", Offset = "0x18C9CC0", VA = "0x1818CB2C0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(TypeParameterTypeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x18CB3F0", Offset = "0x18C9DF0", VA = "0x1818CB3F0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x1D621E0", Offset = "0x1D60BE0", VA = "0x181D621E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x18CB5E0", Offset = "0x18C9FE0", VA = "0x1818CB5E0", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x1D61E70", Offset = "0x1D60870", VA = "0x181D61E70", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x1D620F0", Offset = "0x1D60AF0", VA = "0x181D620F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D68020", Offset = "0x1D66A20", VA = "0x181D68020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x1D679B0", Offset = "0x1D663B0", VA = "0x181D679B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D68840", Offset = "0x1D67240", VA = "0x181D68840")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D68770", Offset = "0x1D67170", VA = "0x181D68770")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D688A0", Offset = "0x1D672A0", VA = "0x181D688A0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x38CC30", Offset = "0x38B630", VA = "0x18038CC30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x38CC20", Offset = "0x38B620", VA = "0x18038CC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		[DebuggerNonUserCode]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0x1D689A0", Offset = "0x1D673A0", VA = "0x181D689A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		[DebuggerNonUserCode]
		public CircuitTypeData SymbolType
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x391210", Offset = "0x38FC10", VA = "0x180391210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x1D686A0", Offset = "0x1D670A0", VA = "0x181D686A0")]
		[DebuggerNonUserCode]
		public VariableNodeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x1D686E0", Offset = "0x1D670E0", VA = "0x181D686E0")]
		[DebuggerNonUserCode]
		public VariableNodeData(VariableNodeData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x1D68150", Offset = "0x1D66B50", VA = "0x181D68150", Slot = "9")]
		[DebuggerNonUserCode]
		public VariableNodeData Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x1D68210", Offset = "0x1D66C10", VA = "0x181D68210", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x1D682D0", Offset = "0x1D66CD0", VA = "0x181D682D0", Slot = "8")]
		[DebuggerNonUserCode]
		public bool Equals(VariableNodeData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x1D68340", Offset = "0x1D66D40", VA = "0x181D68340", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x1D684D0", Offset = "0x1D66ED0", VA = "0x181D684D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x1D68530", Offset = "0x1D66F30", VA = "0x181D68530", Slot = "5")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x1D68080", Offset = "0x1D66A80", VA = "0x181D68080", Slot = "6")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x1D683E0", Offset = "0x1D66DE0", VA = "0x181D683E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x15E8D40", Offset = "0x15E7740", VA = "0x1815E8D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x164A4F0", Offset = "0x1648EF0", VA = "0x18164A4F0")]
		public static TNode CreateNode<TNode>(CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId) where TNode : Node
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x15DC850", Offset = "0x15DB250", VA = "0x1815DC850")]
		internal static Node CreateNodeForDeserialize(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x15DC910", Offset = "0x15DB310", VA = "0x1815DC910")]
		public static Node CreateNode(Type nodeType, CircuitContext context, [Optional] Guid? nodeGuid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x15DCBE0", Offset = "0x15DB5E0", VA = "0x1815DCBE0")]
		public static Node CreateNode(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId, [Optional] Vector3? localPosition, [Optional] Quaternion? localRotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x15DC4E0", Offset = "0x15DAEE0", VA = "0x1815DC4E0")]
		private static Node ConstructNodeInternal(Guid nodeTypeId, CircuitContext context, [Optional] Guid? nodeGuid, [Optional] Guid? innerContextId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x15DD7B0", Offset = "0x15DC1B0", VA = "0x1815DD7B0")]
		public static Guid GetTypeId(Type type)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x15DD060", Offset = "0x15DBA60", VA = "0x1815DD060")]
		public static Type GetNodeType(Guid guid)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x15DCDA0", Offset = "0x15DB7A0", VA = "0x1815DCDA0")]
		public static Tuple<string, Guid>[] GetNodeTypeOptions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x15DD8A0", Offset = "0x15DC2A0", VA = "0x1815DD8A0")]
		public static List<string> OrderedTags()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x15DD170", Offset = "0x15DBB70", VA = "0x1815DD170")]
		public static void GetNodesWithTags(TagSearchMethod tagSearchMethod, IEnumerable<string> activeTags, out HashSet<Type> filteredTypes, out IList<string> filteredTags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x15DDAF0", Offset = "0x15DC4F0", VA = "0x1815DDAF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AA13B0", Offset = "0x1A9FDB0", VA = "0x181AA13B0")]
		public T Get()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x38FA50", Offset = "0x38E450", VA = "0x18038FA50")]
		public void Set(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x1AA13C0", Offset = "0x1A9FDC0", VA = "0x181AA13C0")]
		public Box(in T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x112C060", Offset = "0x112AA60", VA = "0x18112C060")]
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
		[Cpp2IlInjected.Address(RVA = "0x2585090", Offset = "0x2583A90", VA = "0x182585090")]
		public bool TryGetValue(TKey key, out HashSet<TVal> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2584DB0", Offset = "0x25837B0", VA = "0x182584DB0")]
		public void Add(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2584EC0", Offset = "0x25838C0", VA = "0x182584EC0")]
		public void Remove(TKey key, TVal val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x2584E90", Offset = "0x2583890", VA = "0x182584E90")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x25850D0", Offset = "0x2583AD0", VA = "0x1825850D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC99E0", Offset = "0xEC83E0", VA = "0x180EC99E0", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public TVal this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x2585730", Offset = "0x2584130", VA = "0x182585730", Slot = "18")]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x2585780", Offset = "0x2584180", VA = "0x182585780", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x25856A0", Offset = "0x25840A0", VA = "0x1825856A0")]
		public SortedList(Func<TVal, TVal, int> valueComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x25854A0", Offset = "0x2583EA0", VA = "0x1825854A0", Slot = "16")]
		public IEnumerator<TVal> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2585600", Offset = "0x2584000", VA = "0x182585600", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x2585150", Offset = "0x2583B50", VA = "0x182585150", Slot = "11")]
		public void Add(TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2584E90", Offset = "0x2583890", VA = "0x182584E90", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x25853B0", Offset = "0x2583DB0", VA = "0x1825853B0", Slot = "13")]
		public bool Contains(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x25853F0", Offset = "0x2583DF0", VA = "0x1825853F0", Slot = "14")]
		public void CopyTo(TVal[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x25855C0", Offset = "0x2583FC0", VA = "0x1825855C0", Slot = "15")]
		public bool Remove(TVal item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x11B6DB0", Offset = "0x11B57B0", VA = "0x1811B6DB0", Slot = "6")]
		public int IndexOf(TVal item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2585570", Offset = "0x2583F70", VA = "0x182585570", Slot = "7")]
		public void Insert(int index, TVal item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x1032930", Offset = "0x1031330", VA = "0x181032930", Slot = "8")]
		public void RemoveAt(int index)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class EditableValueAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x38C470", Offset = "0x38AE70", VA = "0x18038C470")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B9330", Offset = "0x4B7D30", VA = "0x1804B9330")]
		public EditableAddNamedPort([Optional] string filterMethod)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecOutput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x38C470", Offset = "0x38AE70", VA = "0x18038C470")]
		public EditableAddExecOutput()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditableAddExecInput : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x38C470", Offset = "0x38AE70", VA = "0x18038C470")]
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
			[Cpp2IlInjected.Address(RVA = "0x15EA890", Offset = "0x15E9290", VA = "0x1815EA890")]
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
		[Cpp2IlInjected.Address(RVA = "0x164B000", Offset = "0x1649A00", VA = "0x18164B000")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, [Optional] TVal defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x164AE00", Offset = "0x1649800", VA = "0x18164AE00")]
		public static TVal GetOrCreate<TVal, TKey>(this IDictionary<TKey, TVal> dictionary, TKey key, Func<TVal> defaultVal)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x1B89880", Offset = "0x1B88280", VA = "0x181B89880")]
		public static void AddToNestedList<K, V>(this IDictionary<K, List<V>> self, K key, V value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x1B895C0", Offset = "0x1B87FC0", VA = "0x181B895C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2575B60", Offset = "0x2574560", VA = "0x182575B60", Slot = "4")]
			public bool Equals(T x, T y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x189A350", Offset = "0x1898D50", VA = "0x18189A350", Slot = "5")]
			public int GetHashCode(T obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x1894EA0", Offset = "0x18938A0", VA = "0x181894EA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x1044390", Offset = "0x1042D90", VA = "0x181044390")]
			[DebuggerHidden]
			public <Extend>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x1AB0450", Offset = "0x1AAEE50", VA = "0x181AB0450", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x1AB00A0", Offset = "0x1AAEAA0", VA = "0x181AB00A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0x1AB0520", Offset = "0x1AAEF20", VA = "0x181AB0520")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x1AB0570", Offset = "0x1AAEF70", VA = "0x181AB0570")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x1AB0400", Offset = "0x1AAEE00", VA = "0x181AB0400", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x1AB0340", Offset = "0x1AAED40", VA = "0x181AB0340", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x1040BE0", Offset = "0x103F5E0", VA = "0x181040BE0", Slot = "5")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1FE70", Offset = "0x1F270")]
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
				[Cpp2IlInjected.Address(RVA = "0x413AE0", Offset = "0x4124E0", VA = "0x180413AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x25860A0", Offset = "0x2584AA0", VA = "0x1825860A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x2311320", Offset = "0x230FD20", VA = "0x182311320")]
			[DebuggerHidden]
			public <MarkLast>d__18(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x25865C0", Offset = "0x2584FC0", VA = "0x1825865C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x25862B0", Offset = "0x2584CB0", VA = "0x1825862B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x2586650", Offset = "0x2585050", VA = "0x182586650")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x2586570", Offset = "0x2584F70", VA = "0x182586570", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x2585F00", Offset = "0x2584900", VA = "0x182585F00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, bool)> System.Collections.Generic.IEnumerable<(TValue,System.BooleanIsLast)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x11B2510", Offset = "0x11B0F10", VA = "0x1811B2510", Slot = "5")]
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
			[Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x20AB0", Offset = "0x1FEB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x413AE0", Offset = "0x4124E0", VA = "0x180413AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x25860A0", Offset = "0x2584AA0", VA = "0x1825860A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x2311320", Offset = "0x230FD20", VA = "0x182311320")]
			[DebuggerHidden]
			public <FormCurrentNextPairs>d__19(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x2586180", Offset = "0x2584B80", VA = "0x182586180", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x2585820", Offset = "0x2584220", VA = "0x182585820", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x2586210", Offset = "0x2584C10", VA = "0x182586210")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2586000", Offset = "0x2584A00", VA = "0x182586000", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2585F00", Offset = "0x2584900", VA = "0x182585F00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(T, T)> System.Collections.Generic.IEnumerable<(TCurrent,TNext)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x11B2510", Offset = "0x11B0F10", VA = "0x1811B2510", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x1044390", Offset = "0x1042D90", VA = "0x181044390")]
			[DebuggerHidden]
			public <Unique>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x2588050", Offset = "0x2586A50", VA = "0x182588050", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x25879A0", Offset = "0x25863A0", VA = "0x1825879A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x2588210", Offset = "0x2586C10", VA = "0x182588210")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x2587E30", Offset = "0x2586830", VA = "0x182587E30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x2587D80", Offset = "0x2586780", VA = "0x182587D80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2229820", Offset = "0x2228220", VA = "0x182229820", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x1AB5D30", Offset = "0x1AB4730", VA = "0x181AB5D30")]
		public static U AmountSwitch<U, T>(this IEnumerable<T> self, Func<U> zero, Func<T, U> one, Func<IEnumerable<T>, U> many)
		{
			return (U)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x15EA8F0", Offset = "0x15E92F0", VA = "0x1815EA8F0")]
		public static void CallAll(this IEnumerable<Action> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x1121F10", Offset = "0x1120910", VA = "0x181121F10")]
		public static IEnumerable<T> Concat<T>(params IEnumerable<T>[] items)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x1219C00", Offset = "0x1218600", VA = "0x181219C00")]
		public static string Delimit<T>(this IEnumerable<T> self, string delimiter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x11220D0", Offset = "0x1120AD0", VA = "0x1811220D0")]
		public static IEnumerable<T> Distinct<T, U>(this IEnumerable<T> self, Func<T, U> map)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xB51D10", Offset = "0xB50710", VA = "0x180B51D10")]
		[IteratorStateMachine(typeof(<Extend>d__8<, >))]
		public static IEnumerable<T> Extend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T with)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x1346600", Offset = "0x1345000", VA = "0x181346600")]
		public static int FirstIndexOf<T>(this IEnumerable<T> self, Func<T, bool> pred)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xF0F9B0", Offset = "0xF0E3B0", VA = "0x180F0F9B0")]
		public static T FirstOr<T>(this IEnumerable<T> self, T optB)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x1B8A330", Offset = "0x1B88D30", VA = "0x181B8A330")]
		public static void ForEach<T>(this IEnumerable<T> self, Action<T> op)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x13468D0", Offset = "0x13452D0", VA = "0x1813468D0")]
		public static int SequenceGetHashCode<T>(this IEnumerable<T> self)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x11EDAE0", Offset = "0x11EC4E0", VA = "0x1811EDAE0")]
		public static bool SetEqual<T>(this IEnumerable<T> self, IEnumerable<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x11ED990", Offset = "0x11EC390", VA = "0x1811ED990")]
		public static bool Multiple<T>(this IEnumerable<T> self)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x1121F10", Offset = "0x1120910", VA = "0x181121F10")]
		public static IEnumerable<(T, int)> Index<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xB43590", Offset = "0xB41F90", VA = "0x180B43590")]
		[IteratorStateMachine(typeof(<MarkLast>d__18<>))]
		public static IEnumerable<(T, bool)> MarkLast<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xB43590", Offset = "0xB41F90", VA = "0x180B43590")]
		[IteratorStateMachine(typeof(<FormCurrentNextPairs>d__19<>))]
		public static IEnumerable<(T, T)> FormCurrentNextPairs<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x1122220", Offset = "0x1120C20", VA = "0x181122220")]
		public static IEnumerable<T> NullToEmpty<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x112C0C0", Offset = "0x112AAC0", VA = "0x18112C0C0")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x112C0C0", Offset = "0x112AAC0", VA = "0x18112C0C0")]
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1D000", Offset = "0x1C400")] this IEnumerable<(TKey, TValue)> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x112C060", Offset = "0x112AA60", VA = "0x18112C060")]
		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xB41D90", Offset = "0xB40790", VA = "0x180B41D90")]
		[IteratorStateMachine(typeof(<Unique>d__25<, >))]
		public static IEnumerable<T> Unique<T, U>(this IEnumerable<T> self, Func<T, U> uniqueSelector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x1121D40", Offset = "0x1120740", VA = "0x181121D40")]
		public static IEnumerable<(T, U)> Zip<T, U>(this IEnumerable<T> self, IEnumerable<U> other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xB41E20", Offset = "0xB40820", VA = "0x180B41E20")]
		public static IEnumerable<V> ZipExtend<V, T, U>(this IEnumerable<T> self, IEnumerable<U> other, Func<T, U, V> zipper, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x1122250", Offset = "0x1120C50", VA = "0x181122250")]
		public static IEnumerable<(T, U)> ZipExtend<T, U>(this IEnumerable<T> self, IEnumerable<U> other, [Optional] T selfWith, [Optional] U otherWith)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class EquatableExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x11EDC70", Offset = "0x11EC670", VA = "0x1811EDC70")]
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
				[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0x1044390", Offset = "0x1042D90", VA = "0x181044390")]
			[DebuggerHidden]
			public <ToEnumerable>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x189A7C0", Offset = "0x18991C0", VA = "0x18189A7C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x25870D0", Offset = "0x2585AD0", VA = "0x1825870D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x189A7F0", Offset = "0x18991F0", VA = "0x18189A7F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x11B3970", Offset = "0x11B2370", VA = "0x1811B3970", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x391250", Offset = "0x38FC50", VA = "0x180391250", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x11CBF20", Offset = "0x11CA920", VA = "0x1811CBF20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x22C6AB0", Offset = "0x22C54B0", VA = "0x1822C6AB0")]
			[DebuggerHidden]
			public <ToEnumerableInf>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x2586F20", Offset = "0x2585920", VA = "0x182586F20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x2587000", Offset = "0x2585A00", VA = "0x182587000", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2586F60", Offset = "0x2585960", VA = "0x182586F60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x11B3970", Offset = "0x11B2370", VA = "0x1811B3970", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x11224A0", Offset = "0x1120EA0", VA = "0x1811224A0")]
		[IteratorStateMachine(typeof(<ToEnumerable>d__0<>))]
		public static IEnumerable<T> ToEnumerable<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x1122430", Offset = "0x1120E30", VA = "0x181122430")]
		[IteratorStateMachine(typeof(<ToEnumerableInf>d__1<>))]
		public static IEnumerable<T> ToEnumerableInf<T>(this T self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x1655B80", Offset = "0x1654580", VA = "0x181655B80")]
		public static T[] ToOneItemArray<T>(this T self)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public static class IListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xF0FFF0", Offset = "0xF0E9F0", VA = "0x180F0FFF0")]
		public static T Last<T>(this IList<T> self)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0xF10280", Offset = "0xF0EC80", VA = "0x180F10280")]
		public static T SetLast<T>(this IList<T> self, T value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x1B8EDD0", Offset = "0x1B8D7D0", VA = "0x181B8EDD0")]
		public static void RemoveFirstWhere<T>(this IList<T> self, Func<T, bool> pred)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x1B8EE50", Offset = "0x1B8D850", VA = "0x181B8EE50")]
		public static void RemoveLast<T>(this IList<T> self)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xF10430", Offset = "0xF0EE30", VA = "0x180F10430")]
		public static T TakeLast<T>(this IList<T> self)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public static class IReadOnlyCollectionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x11EF350", Offset = "0x11EDD50", VA = "0x1811EF350")]
		public static bool IsInRange<T>(this IReadOnlyCollection<T> self, int index)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public static class IReadOnlyDictionaryExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x1AB7020", Offset = "0x1AB5A20", VA = "0x181AB7020")]
		public static V GetValueOrDefault<V, K>(this IReadOnlyDictionary<K, V> self, K key)
		{
			return (V)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x121D0D0", Offset = "0x121BAD0", VA = "0x18121D0D0")]
		public static V? GetValueOrNull<V, K>(this IReadOnlyDictionary<K, V> self, K key) where V : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public static class IReadOnlyListExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0xF10480", Offset = "0xF0EE80", VA = "0x180F10480")]
		public static T GetValueOrDefault<T>(this IReadOnlyList<T> self, int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x121D200", Offset = "0x121BC00", VA = "0x18121D200")]
		public static T? GetValueOrNull<T>(this IReadOnlyList<T> self, int index) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public static class KeyValuePairExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x121D350", Offset = "0x121BD50", VA = "0x18121D350")]
		public static (TKey, TValue) Destructure<TKey, TValue>(this KeyValuePair<TKey, TValue> self)
		{
			return default((TKey, TValue));
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x1121F10", Offset = "0x1120910", VA = "0x181121F10")]
		public static IEnumerable<(TKey, TValue)> Destructure<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x96B260", Offset = "0x969C60", VA = "0x18096B260")]
		public static KeyValuePair<TKey, UValue> Revalue<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> self, UValue value)
		{
			return default(KeyValuePair<TKey, UValue>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public static class MapFieldExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x1B93350", Offset = "0x1B91D50", VA = "0x181B93350")]
		public static void AddRange<K, V>(this MapField<K, V> self, IEnumerable<KeyValuePair<K, V>> values)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public static class GuidBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x15EBD00", Offset = "0x15EA700", VA = "0x1815EBD00")]
		private static byte[] GetIntBytes(int intValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x15EB6C0", Offset = "0x15EA0C0", VA = "0x1815EB6C0")]
		public static Guid Combine(params Guid[] guidsToCombine)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x15EBC30", Offset = "0x15EA630", VA = "0x1815EBC30")]
		public static Guid Create(Guid namespaceId, int index, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x15EB830", Offset = "0x15EA230", VA = "0x1815EB830")]
		public static Guid Create(Guid namespaceId, Guid nameGuid, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x15EBBA0", Offset = "0x15EA5A0", VA = "0x1815EBBA0")]
		public static Guid Create(Guid namespaceId, string name, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x15EB8A0", Offset = "0x15EA2A0", VA = "0x1815EB8A0")]
		private static Guid Create(Guid namespaceId, byte[] nameBytes, int version = 5)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x15EBD80", Offset = "0x15EA780", VA = "0x1815EBD80")]
		private static void SwapByteOrder(byte[] guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x15EBF30", Offset = "0x15EA930", VA = "0x1815EBF30")]
		private static void SwapBytes(byte[] guid, int left, int right)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public class InternalNodeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x38C470", Offset = "0x38AE70", VA = "0x18038C470")]
		public InternalNodeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public static class NodeNameHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x15EC1C0", Offset = "0x15EABC0", VA = "0x1815EC1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1369E0", Offset = "0x135DE0", VA = "0x1801369E0")]
		public PerfScope(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x1369E0", Offset = "0x135DE0", VA = "0x1801369E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x15ED330", Offset = "0x15EBD30", VA = "0x1815ED330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x15ED1E0", Offset = "0x15EBBE0", VA = "0x1815ED1E0")]
		public RateLimiter(ITimeProvider timeProvider, int maxPerSecond, int initialSize = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x15ECF00", Offset = "0x15EB900", VA = "0x1815ECF00")]
		public bool CanExecute()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x15ECF60", Offset = "0x15EB960", VA = "0x1815ECF60")]
		public bool ExecuteIfPossible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x15ED030", Offset = "0x15EBA30", VA = "0x1815ED030")]
		public void MarkExecution()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x15ED0A0", Offset = "0x15EBAA0", VA = "0x1815ED0A0")]
		private void TrimExpiredValues()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x4B3A10", Offset = "0x4B2410", VA = "0x1804B3A10")]
		public static T[] NewArray<T>(params T[] @params)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x96BA00", Offset = "0x96A400", VA = "0x18096BA00")]
		public static KeyValuePair<TKey, TValue> NewKeyValuePair<TKey, TValue>(TKey key, TValue value)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x11F8BD0", Offset = "0x11F75D0", VA = "0x1811F8BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15EE560", Offset = "0x15ECF60", VA = "0x1815EE560")]
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
		[Cpp2IlInjected.Address(RVA = "0x38C470", Offset = "0x38AE70", VA = "0x18038C470")]
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
		[Cpp2IlInjected.Address(RVA = "0x18CA390", Offset = "0x18C8D90", VA = "0x1818CA390")]
		public CircuitDataIdRemapper(bool remapIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x18CA300", Offset = "0x18C8D00", VA = "0x1818CA300")]
		public CircuitDataIdRemapper(bool remapIds, Guid remapId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x18CA0C0", Offset = "0x18C8AC0", VA = "0x1818CA0C0")]
		public ByteString RemapByteStringId(ByteString originalByteString, bool onlyIfAlreadyMapped = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public static class CircuitTemplateHelper
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x18D3C30", Offset = "0x18D2630", VA = "0x1818D3C30")]
		public static CircuitContextData RemapTemplate(CircuitContext intoContext, CircuitContextData originalTemplate, Guid remapId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x18D3F10", Offset = "0x18D2910", VA = "0x1818D3F10")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x18D3FB0", Offset = "0x18D29B0", VA = "0x1818D3FB0")]
		internal static IEnumerable<CircuitObject> SpawnFromTemplate(CircuitContext intoContext, CircuitContextData templateData, Matrix4x4 transformMatrix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x18D2110", Offset = "0x18D0B10", VA = "0x1818D2110")]
		public static void AddInventionTracking(CircuitContextData templateData, ByteString instanceIdAsByteString, long inventionId, int versionNum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x18D35D0", Offset = "0x18D1FD0", VA = "0x1818D35D0")]
		public static void RemapTemplateIds(CircuitContext intoContext, CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x18D31B0", Offset = "0x18D1BB0", VA = "0x1818D31B0")]
		private static void RemapNodeInnerContextIdsRecursive(CircuitDataIdRemapper remapper, CircuitContextData context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x18D25F0", Offset = "0x18D0FF0", VA = "0x1818D25F0")]
		private static void RemapContextIdsRecursive(CircuitDataIdRemapper remapper, RepeatedField<CircuitContextData> contexts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x18D2B70", Offset = "0x18D1570", VA = "0x1818D2B70")]
		private static void RemapInventionInstanceIds(CircuitDataIdRemapper remapper, CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x18D2FF0", Offset = "0x18D19F0", VA = "0x1818D2FF0")]
		private static void RemapNodeDataEventIds(IEnumerable<CircuitNodeData> nodeDatas, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x18D2870", Offset = "0x18D1270", VA = "0x1818D2870")]
		private static void RemapEventRegistrationList(IList<EventRegistrationData> registrationList, CircuitDataIdRemapper remapper)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x18D3D50", Offset = "0x18D2750", VA = "0x1818D3D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1292050", Offset = "0x1290A50", VA = "0x181292050")]
		public static Create<TCircuitObject, TProtoElement> DoNotCreate<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement> where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x1292050", Offset = "0x1290A50", VA = "0x181292050")]
		public static Dispose<TCircuitObject, TProtoElement> IDisposableDispose<TCircuitObject, TProtoElement>() where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable where TProtoElement : IMessage
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x12229B0", Offset = "0x12213B0", VA = "0x1812229B0")]
		public static void MergeDisposablesProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>, IDisposable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x1BA43E0", Offset = "0x1BA2DE0", VA = "0x181BA43E0")]
		public static void MergeProtobuf<TProtoElement, TCircuitObject>(IEnumerable<TProtoElement> protobufDatas, Func<TProtoElement, Guid> getGuid, IReadOnlyDictionary<Guid, TCircuitObject> existingObjects, Create<TCircuitObject, TProtoElement> create, Dispose<TCircuitObject, TProtoElement> dispose, [Optional] Initialize<TCircuitObject> postDeserialize) where TProtoElement : IMessage where TCircuitObject : class, ICircuitSerializable<TProtoElement>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x1222610", Offset = "0x1221010", VA = "0x181222610")]
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
			[Cpp2IlInjected.Address(RVA = "0x1040BA0", Offset = "0x103F5A0", VA = "0x181040BA0")]
			public Binder(Dependencies dependencies)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x1281180", Offset = "0x127FB80", VA = "0x181281180")]
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
			[Cpp2IlInjected.Address(RVA = "0x237030", Offset = "0x236430", VA = "0x180237030")]
			public bool Equals(InjectionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x236F70", Offset = "0x236370", VA = "0x180236F70", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x2370A0", Offset = "0x2364A0", VA = "0x1802370A0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly Dictionary<InjectionKey, object> injectedInstancesDictionary;

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x112C060", Offset = "0x112AA60", VA = "0x18112C060")]
		public Binder<TInterface> Bind<TInterface>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x164ACF0", Offset = "0x16496F0", VA = "0x18164ACF0")]
		public TInterface GetDependency<TInterface>([Optional] string name)
		{
			return (TInterface)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x18D67E0", Offset = "0x18D51E0", VA = "0x1818D67E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x38CC30", Offset = "0x38B630", VA = "0x18038CC30")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000842")]
				[Cpp2IlInjected.Address(RVA = "0x38CC20", Offset = "0x38B620", VA = "0x18038CC20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000189")]
			public Guid Address
			{
				[Cpp2IlInjected.Token(Token = "0x6000843")]
				[Cpp2IlInjected.Address(RVA = "0x3AFB20", Offset = "0x3AE520", VA = "0x1803AFB20", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x1AA8DF0", Offset = "0x1AA77F0", VA = "0x181AA8DF0")]
			protected MemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x1AA8D80", Offset = "0x1AA7780", VA = "0x181AA8D80", Slot = "6")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(Slot = "7")]
			protected abstract void DisposeInternal();

			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0x1AA8BC0", Offset = "0x1AA75C0", VA = "0x181AA8BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AAFB80", Offset = "0x1AAE580", VA = "0x181AAFB80")]
			public SymbolMemoryHandle(Memory memory, Guid address, string symbol, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0x1AAF880", Offset = "0x1AAE280", VA = "0x181AAF880", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x1AAFA60", Offset = "0x1AAE460", VA = "0x181AAFA60", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private class UnnamedMemoryHandle<TVal> : MemoryHandle<TVal>
		{
			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x1AB3B90", Offset = "0x1AB2590", VA = "0x181AB3B90")]
			public UnnamedMemoryHandle(Memory memory, Guid address, Dictionary<Guid, TVal> allocatedInDictionary, Action<Guid, TVal> customDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x1AB3770", Offset = "0x1AB2170", VA = "0x181AB3770", Slot = "7")]
			protected override void DisposeInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x1AB3950", Offset = "0x1AB2350", VA = "0x181AB3950", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1487130", Offset = "0x1485B30", VA = "0x181487130")]
		public Memory(CircuitContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x1485FE0", Offset = "0x14849E0", VA = "0x181485FE0")]
		private void OnGuidsRemapped(IReadOnlyDictionary<Guid, ShortenedGuidMap.GuidRemapping> remappedguids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x12204B0", Offset = "0x121EEB0", VA = "0x1812204B0")]
		private void RemapDictionary<T>(Dictionary<Guid, RateLimitedSynchronizedField<T>> synchronizedFieldDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x14863C0", Offset = "0x1484DC0", VA = "0x1814863C0")]
		private void OnHandleReleased(IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x1486090", Offset = "0x1484A90", VA = "0x181486090")]
		private void OnHandleReleased(string symbol, IMemoryHandle handle, Action deallocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x12881E0", Offset = "0x1286BE0", VA = "0x1812881E0")]
		public IMemoryHandle AllocateNamedVariable<T>(string symbol, Guid defaultAddress, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x12894C0", Offset = "0x1287EC0", VA = "0x1812894C0")]
		public IMemoryHandle AllocateUnnamedVariable<T>(Guid address, Dictionary<Guid, T> variableDict, Action<Guid, T> customDispose)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x15BA1E0", Offset = "0x15B8BE0", VA = "0x1815BA1E0")]
		private Guid InitializeLocal<T>(Guid address, Dictionary<Guid, T> dictionary, T value)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x15BA360", Offset = "0x15B8D60", VA = "0x1815BA360")]
		private Guid InitializeSynchronized<T>(Guid address, Dictionary<Guid, RateLimitedSynchronizedField<T>> dictionary, T initialValue)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x1220450", Offset = "0x121EE50", VA = "0x181220450")]
		private void DeallocateSynchronized<T>(Guid address, RateLimitedSynchronizedField<T> field)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x11F35E0", Offset = "0x11F1FE0", VA = "0x1811F35E0")]
		private bool AllocateOrReference<T>(Guid defaultAddress, CircuitType valueType, Dictionary<Guid, T> typeMemory, out IMemoryHandle handle, [Optional] string variableName, [Optional] Action<Guid, T> customDispose)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x12887A0", Offset = "0x12871A0", VA = "0x1812887A0")]
		private IMemoryHandle AllocateOrReferenceLocal<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, T> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x1288DB0", Offset = "0x12877B0", VA = "0x181288DB0")]
		private IMemoryHandle AllocateOrReferenceSynchronized<T>(Guid defaultAddress, CircuitType circuitType, T initialValue, string variableName, Dictionary<Guid, RateLimitedSynchronizedField<T>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x1485410", Offset = "0x1483E10", VA = "0x181485410")]
		public IMemoryHandle AllocateBoolean(Guid defaultAddress, bool value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x14854C0", Offset = "0x1483EC0", VA = "0x1814854C0")]
		public IMemoryHandle AllocateInt32(Guid defaultAddress, int value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x1485620", Offset = "0x1484020", VA = "0x181485620")]
		public IMemoryHandle AllocateSingle(Guid defaultAddress, float value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x14856D0", Offset = "0x14840D0", VA = "0x1814856D0")]
		public IMemoryHandle AllocateString(Guid defaultAddress, string value, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x1485570", Offset = "0x1483F70", VA = "0x181485570")]
		public IMemoryHandle AllocateOrReferenceSynchronizedBoolean(Guid defaultAddress, bool initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x1485780", Offset = "0x1484180", VA = "0x181485780")]
		public IMemoryHandle AllocateSynchronizedInt32(Guid defaultAddress, int initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x1485830", Offset = "0x1484230", VA = "0x181485830")]
		public IMemoryHandle AllocateSynchronizedSingle(Guid defaultAddress, float initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x14858E0", Offset = "0x14842E0", VA = "0x1814858E0")]
		public IMemoryHandle AllocateSynchronizedString(Guid defaultAddress, string initialValue, [Optional] string variableName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x1485C60", Offset = "0x1484660", VA = "0x181485C60")]
		public bool GetBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x1485CC0", Offset = "0x14846C0", VA = "0x181485CC0")]
		public int GetInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x1485D20", Offset = "0x1484720", VA = "0x181485D20")]
		public float GetSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x1485D80", Offset = "0x1484780", VA = "0x181485D80")]
		public string GetString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x1485DE0", Offset = "0x14847E0", VA = "0x181485DE0")]
		public bool GetSynchronizedBoolean(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x1485E60", Offset = "0x1484860", VA = "0x181485E60")]
		public int GetSynchronizedInt32(Guid id)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x1485EE0", Offset = "0x14848E0", VA = "0x181485EE0")]
		public float GetSynchronizedSingle(Guid id)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x1485F60", Offset = "0x1484960", VA = "0x181485F60")]
		public string GetSynchronizedString(Guid id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x11F4420", Offset = "0x11F2E20", VA = "0x1811F4420")]
		private bool SetValue<T>(Guid id, T value, Dictionary<Guid, T> values) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x1486B20", Offset = "0x1485520", VA = "0x181486B20")]
		public bool SetBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x1486B90", Offset = "0x1485590", VA = "0x181486B90")]
		public bool SetInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x1486C00", Offset = "0x1485600", VA = "0x181486C00")]
		public bool SetSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x1486C70", Offset = "0x1485670", VA = "0x181486C70")]
		public bool SetString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x1486D20", Offset = "0x1485720", VA = "0x181486D20")]
		public bool SetSynchronizedBoolean(Guid id, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x1486DB0", Offset = "0x14857B0", VA = "0x181486DB0")]
		public bool SetSynchronizedInt32(Guid id, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x1486E40", Offset = "0x1485840", VA = "0x181486E40")]
		public bool SetSynchronizedSingle(Guid id, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x1486ED0", Offset = "0x14858D0", VA = "0x181486ED0")]
		public bool SetSynchronizedString(Guid id, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x1486720", Offset = "0x1485120", VA = "0x181486720")]
		public void RegisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x14870B0", Offset = "0x1485AB0", VA = "0x1814870B0")]
		public void UnregisterValueChangedListener(Guid address, IVariableChangeListener listener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x14864E0", Offset = "0x1484EE0", VA = "0x1814864E0")]
		private void OnValueChanged(RateLimiter rateLimiter, Guid address)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x1486F90", Offset = "0x1485990", VA = "0x181486F90")]
		private static string Truncate(string originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x1486FE0", Offset = "0x14859E0", VA = "0x181486FE0")]
		public bool TryGetNamedVariable(string varName, out Guid variableAddress, out CircuitType variableType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x14867A0", Offset = "0x14851A0", VA = "0x1814867A0")]
		public void RemapNamedVariables(CircuitContextData templateData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0x1485990", Offset = "0x1484390", VA = "0x181485990")]
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
			[Cpp2IlInjected.Address(RVA = "0x1442E0", Offset = "0x1436E0", VA = "0x1801442E0")]
			public TypeConversionKey(TypeKind fromKind, TypeKind toKind)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0x18F6C0", Offset = "0x18EAC0", VA = "0x18018F6C0")]
			public bool Equals(TypeConversionKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0x18F6E0", Offset = "0x18EAE0", VA = "0x18018F6E0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x18F770", Offset = "0x18EB70", VA = "0x18018F770", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x14880B0", Offset = "0x1486AB0", VA = "0x1814880B0")]
		public static bool IsConvertableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x1487E40", Offset = "0x1486840", VA = "0x181487E40")]
		public static Func<Node, Node, (Node, ITypeConversionNode)> GetConverterConstructor(CircuitType from, CircuitType to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x14883B0", Offset = "0x1486DB0", VA = "0x1814883B0")]
		public static bool SupportsDefaultValue(CircuitType signalType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x1488170", Offset = "0x1486B70", VA = "0x181488170")]
		public static void RegisterFriendlyName(Guid name, string friendlyName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x1487F60", Offset = "0x1486960", VA = "0x181487F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x148A2A0", Offset = "0x1488CA0", VA = "0x18148A2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x1488B90", Offset = "0x1487590", VA = "0x181488B90", Slot = "4")]
		public bool AllowsMultipleInputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x1488BC0", Offset = "0x14875C0", VA = "0x181488BC0", Slot = "5")]
		public bool AllowsMultipleOutputs(CircuitType type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x14894C0", Offset = "0x1487EC0", VA = "0x1814894C0", Slot = "6")]
		public bool IsAssignableTo(CircuitType from, CircuitType to)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x1488D90", Offset = "0x1487790", VA = "0x181488D90")]
		private bool IsAssignableToInternal(CircuitType from, CircuitType to, IReadOnlyList<CircuitType> fromTypeParameterAssignments, IReadOnlyList<CircuitType> toTypeParameterAssignments)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x1489550", Offset = "0x1487F50", VA = "0x181489550", Slot = "7")]
		public CircuitType Narrow(CircuitType typeA, CircuitType typeB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x1488BF0", Offset = "0x14875F0", VA = "0x181488BF0")]
		private static (CircuitType, IReadOnlyList<CircuitType>, bool) ExtractTypeSpecifics(CircuitType type, IReadOnlyList<CircuitType> lastAssignments)
		{
			return default((CircuitType, IReadOnlyList<CircuitType>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
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
			[Cpp2IlInjected.Address(RVA = "0x1487D50", Offset = "0x1486750", VA = "0x181487D50")]
			public TransformModificationHandler(CircuitObject modifiedObject)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x14879A0", Offset = "0x14863A0", VA = "0x1814879A0")]
			public ICircuitObjectModification CreateModification(Vector3? newLocalPosition, Quaternion? newLocalRotation)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0x1487AD0", Offset = "0x14864D0", VA = "0x181487AD0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3972E0", Offset = "0x395CE0", VA = "0x1803972E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B62F0", Offset = "0x3B4CF0", VA = "0x1803B62F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x5604B0", Offset = "0x55EEB0", VA = "0x1805604B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public bool CanSetName
		{
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x147AF00", Offset = "0x1479900", VA = "0x18147AF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public bool CanDestroy
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x147AEA0", Offset = "0x14798A0", VA = "0x18147AEA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action OnDestroyed
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x147AD60", Offset = "0x1479760", VA = "0x18147AD60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0x147AF50", Offset = "0x1479950", VA = "0x18147AF50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action OnNameChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x147AE00", Offset = "0x1479800", VA = "0x18147AE00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x147AFF0", Offset = "0x14799F0", VA = "0x18147AFF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x147ABE0", Offset = "0x14795E0", VA = "0x18147ABE0")]
		protected CircuitObject(CircuitContext context, Guid objectId, CircuitObjectType objectType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x147A9E0", Offset = "0x14793E0", VA = "0x18147A9E0")]
		internal void SetCanDestroy(bool canDestroy, CircuitTokenFlag.CircuitToken token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x147A840", Offset = "0x1479240", VA = "0x18147A840")]
		public void RequestTransformChange(Vector3? newPosition, Quaternion? newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x1217F00", Offset = "0x1216900", VA = "0x181217F00")]
		public void RegisterModificationHandler<T>(T handler) where T : ICircuitObjectModificationHandler
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x11EB680", Offset = "0x11EA080", VA = "0x1811EB680")]
		public bool TryGetModificationHandler<T>(out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x11EB750", Offset = "0x11EA150", VA = "0x1811EB750")]
		public bool TryGetModificationHandler<T>(Guid handlerId, out T modificationHandler) where T : ICircuitObjectModificationHandler
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x147AB80", Offset = "0x1479580", VA = "0x18147AB80")]
		public bool UnregisterModificationHandler(Guid guid)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x147A670", Offset = "0x1479070", VA = "0x18147A670")]
		public void HandleModificationRequest(Guid modificationHandlerId, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x147A620", Offset = "0x1479020", VA = "0x18147A620", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x147A780", Offset = "0x1479180", VA = "0x18147A780")]
		public bool RequestChangeName(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x679E10", Offset = "0x678810", VA = "0x180679E10", Slot = "8")]
		public virtual bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x7DC330", Offset = "0x7DAD30", VA = "0x1807DC330")]
		protected void RaiseOnNameChangedEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public abstract class CircuitObject<TProto> : CircuitObject, ICircuitSerializable<TProto> where TProto : IMessage
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4310", Offset = "0x1AA2D10", VA = "0x181AA4310")]
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
		[Cpp2IlInjected.Address(RVA = "0x18ED60", Offset = "0x18E160", VA = "0x18018ED60")]
		public CircuitObjectId(Guid contextId, Guid objectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x18ECE0", Offset = "0x18E0E0", VA = "0x18018ECE0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x147D690", Offset = "0x147C090", VA = "0x18147D690")]
		protected ExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x147D660", Offset = "0x147C060", VA = "0x18147D660")]
		protected ExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		protected abstract NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope);

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x147D470", Offset = "0x147BE70", VA = "0x18147D470")]
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
			[Cpp2IlInjected.Address(RVA = "0x147D760", Offset = "0x147C160", VA = "0x18147D760", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int MyExecutionCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x391250", Offset = "0x38FC50", VA = "0x180391250", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public bool ExecutionLimited
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x38CC30", Offset = "0x38B630", VA = "0x18038CC30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xCF6990", Offset = "0xCF5390", VA = "0x180CF6990")]
		public ExecutionScope([NotNull] CircuitContext executionScopeContext)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x147D6C0", Offset = "0x147C0C0", VA = "0x18147D6C0", Slot = "7")]
		public bool MarkExecution()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xD043B0", Offset = "0xD02DB0", VA = "0x180D043B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x13AF80", Offset = "0x13A380", VA = "0x18013AF80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x18F620", Offset = "0x18EA20", VA = "0x18018F620")]
		private DisconnectionResult(DisconnectionResultKind kind)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x18F630", Offset = "0x18EA30", VA = "0x18018F630")]
		private DisconnectionResult(int indexOfDstInSrc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x147C7F0", Offset = "0x147B1F0", VA = "0x18147C7F0")]
		public static DisconnectionResult Ok(int indexOfDstInSrc)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x147C7D0", Offset = "0x147B1D0", VA = "0x18147C7D0")]
		public static DisconnectionResult ErrorNull()
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x147C7B0", Offset = "0x147B1B0", VA = "0x18147C7B0")]
		public static DisconnectionResult ErrorNotConnected()
		{
			return default(DisconnectionResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public static class GraphOp
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x1481B80", Offset = "0x1480580", VA = "0x181481B80")]
		private static ConnectionResult CanConnect(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x1482180", Offset = "0x1480B80", VA = "0x181482180")]
		public static ConnectionResult ConnectByRequest(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x14826B0", Offset = "0x14810B0", VA = "0x1814826B0")]
		internal static ConnectionResult ConnectLocal(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default(ConnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x1482BD0", Offset = "0x14815D0", VA = "0x181482BD0")]
		internal static void ConnectLocal(CircuitContext context, Guid srcNodeId, Guid srcPortId, Guid dstNodeId, Guid dstPortId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x14823D0", Offset = "0x1480DD0", VA = "0x1814823D0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) ConnectCore(Node srcNode, OutputPort srcPort, Node dstNode, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x1482D90", Offset = "0x1481790", VA = "0x181482D90")]
		private static bool CreatesCycle(Node srcNode, Node dstNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x1484800", Offset = "0x1483200", VA = "0x181484800")]
		private static bool IsConnected(Node srcNode, Node dstNode, OutputPort srcPort, InputPort dstPort)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x1482110", Offset = "0x1480B10", VA = "0x181482110")]
		private static DisconnectionResult CanDisconnect(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x1483ED0", Offset = "0x14828D0", VA = "0x181483ED0")]
		internal static DisconnectionResult DisconnectLocal(OutputPort srcPort, InputPort dstPort)
		{
			return default(DisconnectionResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x1483820", Offset = "0x1482220", VA = "0x181483820")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectCore(OutputPort srcPort, InputPort dstPort, int indexOfDstInSrc)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x14845A0", Offset = "0x1482FA0", VA = "0x1814845A0")]
		private static int IndexOfDstInSrc(OutputPort srcPort, InputPort dstPort)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x1483B00", Offset = "0x1482500", VA = "0x181483B00")]
		private static (IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>) DisconnectForConnect(OutputPort srcPort, InputPort dstPort)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>, Func<(IEnumerable<Action>, IEnumerable<Node>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x14820F0", Offset = "0x1480AF0", VA = "0x1814820F0")]
		private static bool CanDisconnectPort(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x1483F90", Offset = "0x1482990", VA = "0x181483F90")]
		public static bool DisconnectPortByRequest(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x1484530", Offset = "0x1482F30", VA = "0x181484530")]
		internal static bool DisconnectPortLocal(PortBase port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x14843A0", Offset = "0x1482DA0", VA = "0x1814843A0")]
		internal static void DisconnectPortLocal(CircuitContext context, Guid nodeId, Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x14841C0", Offset = "0x1482BC0", VA = "0x1814841C0")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DisconnectPortCore(PortBase port)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x1483560", Offset = "0x1481F60", VA = "0x181483560")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyPortGroupCore(IPortGroup portGroup)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x1482070", Offset = "0x1480A70", VA = "0x181482070")]
		private static bool CanDestroyNode(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x14834A0", Offset = "0x1481EA0", VA = "0x1814834A0")]
		internal static bool DestroyNodeLocal(Node node)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x1482F30", Offset = "0x1481930", VA = "0x181482F30")]
		internal static (IEnumerable<Action>, IEnumerable<Node>) DestroyNodeCore(Node node)
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x1484660", Offset = "0x1483060", VA = "0x181484660")]
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
			[Cpp2IlInjected.Address(RVA = "0x168EFB0", Offset = "0x168D9B0", VA = "0x18168EFB0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		internal Dictionary<string, CircuitType> LastTypeDictionary
		{
			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0x413B40", Offset = "0x412540", VA = "0x180413B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0x4C70A0", Offset = "0x4C5AA0", VA = "0x1804C70A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public IEnumerable<InputPort> InputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0x168EF60", Offset = "0x168D960", VA = "0x18168EF60", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public IEnumerable<InputPort> InputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D7")]
			[Cpp2IlInjected.Address(RVA = "0x168EE50", Offset = "0x168D850", VA = "0x18168EE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public IEnumerable<OutputPort> OutputPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0x168F190", Offset = "0x168DB90", VA = "0x18168F190", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public IEnumerable<OutputPort> OutputPortsOrdered
		{
			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0x168F080", Offset = "0x168DA80", VA = "0x18168F080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public IEnumerable<PortGroupBase<InputPort>> InputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0x168EE00", Offset = "0x168D800", VA = "0x18168EE00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public IEnumerable<PortGroupBase<OutputPort>> OutputPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x60008DB")]
			[Cpp2IlInjected.Address(RVA = "0x168F030", Offset = "0x168DA30", VA = "0x18168F030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public FunctionType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60008DC")]
			[Cpp2IlInjected.Address(RVA = "0x413B90", Offset = "0x412590", VA = "0x180413B90", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x168F280", Offset = "0x168DC80", VA = "0x18168F280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action OnPortsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x168ED60", Offset = "0x168D760", VA = "0x18168ED60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x168F1E0", Offset = "0x168DBE0", VA = "0x18168F1E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x168E560", Offset = "0x168CF60", VA = "0x18168E560", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x168DAD0", Offset = "0x168C4D0", VA = "0x18168DAD0")]
		public string GetNodeName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x168E990", Offset = "0x168D390", VA = "0x18168E990")]
		protected Node(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x168DBF0", Offset = "0x168C5F0", VA = "0x18168DBF0")]
		public bool RequestSetPortDefaultValue(PortBase port, CircuitSignal value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x168DAE0", Offset = "0x168C4E0", VA = "0x18168DAE0", Slot = "16")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x168E5B0", Offset = "0x168CFB0", VA = "0x18168E5B0")]
		public void SetSpecificTypes(IEnumerable<(string, CircuitType)> genericTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x168E8F0", Offset = "0x168D2F0", VA = "0x18168E8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "17")]
		protected virtual void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x168DF60", Offset = "0x168C960", VA = "0x18168DF60", Slot = "10")]
		public sealed override CircuitNodeData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x168DD60", Offset = "0x168C760", VA = "0x18168DD60")]
		[CanBeNull]
		private InventionPieceData SerializeInventionPieceData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x168D6A0", Offset = "0x168C0A0", VA = "0x18168D6A0", Slot = "11")]
		public sealed override void DeserializeFromProtobuf(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x168CF60", Offset = "0x168B960", VA = "0x18168CF60")]
		public void DeserializeConnections(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "18")]
		protected virtual void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "19")]
		protected virtual void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x168D9B0", Offset = "0x168C3B0", VA = "0x18168D9B0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x168DA30", Offset = "0x168C430", VA = "0x18168DA30", Slot = "20")]
		protected internal virtual (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x168DBB0", Offset = "0x168C5B0", VA = "0x18168DBB0")]
		internal void RaiseOnPortsUpdatedEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x168DAA0", Offset = "0x168C4A0", VA = "0x18168DAA0", Slot = "21")]
		public virtual IEnumerable<(TypeParameterId<Node>, TypeParameterId<Node>)> GetAdditionalEquivalentTypeParameters()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x168CEC0", Offset = "0x168B8C0", VA = "0x18168CEC0")]
		protected static FunctionType CTypeParams(params TypeParamConstrainedOrNot[] typeParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x168CCE0", Offset = "0x168B6E0", VA = "0x18168CCE0")]
		private static InputPort BuildInputPort(Guid portId, string portName, CircuitTypeOrString portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x168CDD0", Offset = "0x168B7D0", VA = "0x18168CDD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x160A0D0", Offset = "0x1608AD0", VA = "0x18160A0D0")]
		public NodeConnection([NotNull] Node srcNode, [NotNull] OutputPort srcPort, [NotNull] Node dstNode, [NotNull] InputPort dstPort)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x168C9A0", Offset = "0x168B3A0", VA = "0x18168C9A0")]
		protected bool Equals(NodeConnection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x168C890", Offset = "0x168B290", VA = "0x18168C890", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x168C9E0", Offset = "0x168B3E0", VA = "0x18168C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x956270", Offset = "0x954C70", VA = "0x180956270")]
		public static bool operator !=(NodeConnection left, NodeConnection right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x168CB70", Offset = "0x168B570", VA = "0x18168CB70", Slot = "9")]
		public NodeConnectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x168C840", Offset = "0x168B240", VA = "0x18168C840", Slot = "8")]
		public void DeserializeFromProtobuf(NodeConnectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x168CAA0", Offset = "0x168B4A0", VA = "0x18168CAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x40AB40", Offset = "0x409540", VA = "0x18040AB40", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600090C")]
			[Cpp2IlInjected.Address(RVA = "0x1AA1330", Offset = "0x1A9FD30", VA = "0x181AA1330", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x1AA12D0", Offset = "0x1A9FCD0", VA = "0x181AA12D0")]
		public BasicPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x1AA1000", Offset = "0x1A9FA00", VA = "0x181AA1000")]
		internal void AddPortLocal(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x1AA1030", Offset = "0x1A9FA30", VA = "0x181AA1030", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x1AA1150", Offset = "0x1A9FB50", VA = "0x181AA1150", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x5C7100", Offset = "0x5C5B00", VA = "0x1805C7100", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4C30", Offset = "0x1AA3630", VA = "0x181AA4C30")]
		public DynamicPortGroupModificationHandler(Node node, PortGroupBase<TPort> portGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x1AA47C0", Offset = "0x1AA31C0", VA = "0x181AA47C0")]
		public ICircuitObjectModification CreateAddModification(Guid portId, string portName, CircuitType portType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4990", Offset = "0x1AA3390", VA = "0x181AA4990")]
		public ICircuitObjectModification CreateRemoveModification(Guid portId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4B00", Offset = "0x1AA3500", VA = "0x181AA4B00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x413B70", Offset = "0x412570", VA = "0x180413B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x429BD0", Offset = "0x4285D0", VA = "0x180429BD0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x1AA50B0", Offset = "0x1AA3AB0", VA = "0x181AA50B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4E40", Offset = "0x1AA3840", VA = "0x181AA4E40")]
		public ExecNameBasedPortGroup(string execPortName, PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4D10", Offset = "0x1AA3710", VA = "0x181AA4D10")]
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
			[Cpp2IlInjected.Address(RVA = "0x413B40", Offset = "0x412540", VA = "0x180413B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public override PortGroupType PortGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0x44BBA0", Offset = "0x44A5A0", VA = "0x18044BBA0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0x1AA50B0", Offset = "0x1AA3AB0", VA = "0x181AA50B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public override bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0x1AA7F40", Offset = "0x1AA6940", VA = "0x181AA7F40", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7DA0", Offset = "0x1AA67A0", VA = "0x181AA7DA0")]
		public IndexBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory, string elementName, CircuitTypeOrString elementPortType, int minPortCount = 0, int maxPortCount = 64)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7660", Offset = "0x1AA6060", VA = "0x181AA7660", Slot = "16")]
		public override bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7460", Offset = "0x1AA5E60", VA = "0x181AA7460")]
		public TPort AddPortLocal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x1AA79D0", Offset = "0x1AA63D0", VA = "0x181AA79D0")]
		private void RemoveLastPortLocal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7C00", Offset = "0x1AA6600", VA = "0x181AA7C00", Slot = "18")]
		protected override void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7720", Offset = "0x1AA6120", VA = "0x181AA7720", Slot = "19")]
		protected override void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7AB0", Offset = "0x1AA64B0", VA = "0x181AA7AB0", Slot = "24")]
		public void RequestAddPort()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7930", Offset = "0x1AA6330", VA = "0x181AA7930", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7960", Offset = "0x1AA6360", VA = "0x181AA7960", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x1689790", Offset = "0x1688190", VA = "0x181689790", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		private OutputPort FirstConnectedPort
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x1689730", Offset = "0x1688130", VA = "0x181689730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0x1689690", Offset = "0x1688090", VA = "0x181689690", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public bool SupportsDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0x16898B0", Offset = "0x16882B0", VA = "0x1816898B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public bool HasCustomDefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0x16897E0", Offset = "0x16881E0", VA = "0x1816897E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public CircuitSignal DefaultSignalValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0x1689710", Offset = "0x1688110", VA = "0x181689710")]
			get
			{
				return default(CircuitSignal);
			}
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0x16899D0", Offset = "0x16883D0", VA = "0x1816899D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action OnDefaultSignalValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000936")]
			[Cpp2IlInjected.Address(RVA = "0x16895F0", Offset = "0x1687FF0", VA = "0x1816895F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000937")]
			[Cpp2IlInjected.Address(RVA = "0x1689930", Offset = "0x1688330", VA = "0x181689930")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x1689180", Offset = "0x1687B80", VA = "0x181689180", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x1689590", Offset = "0x1687F90", VA = "0x181689590")]
		public InputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, bool canSet = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x16892C0", Offset = "0x1687CC0", VA = "0x1816892C0", Slot = "12")]
		protected override void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x1689210", Offset = "0x1687C10", VA = "0x181689210", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x1689500", Offset = "0x1687F00", VA = "0x181689500", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x16891A0", Offset = "0x1687BA0", VA = "0x1816891A0", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x1689050", Offset = "0x1687A50", VA = "0x181689050")]
		private CircuitSignal DefaultValue(TypeKind kind)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x1689430", Offset = "0x1687E30", VA = "0x181689430")]
		public DefaultPortData SerializeCustomDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x16890C0", Offset = "0x1687AC0", VA = "0x1816890C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x38E8D0", Offset = "0x38D2D0", VA = "0x18038E8D0", Slot = "11")]
			get
			{
				return default(PortGroupType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public override SerializationHelpers.Create<TPort, NodePortData> CreatePortOnDeserializeFunc
		{
			[Cpp2IlInjected.Token(Token = "0x6000941")]
			[Cpp2IlInjected.Address(RVA = "0x1AA50B0", Offset = "0x1AA3AB0", VA = "0x181AA50B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9C40", Offset = "0x1AA8640", VA = "0x181AA9C40")]
		public NameBasedPortGroup(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x1AA99D0", Offset = "0x1AA83D0", VA = "0x181AA99D0", Slot = "26")]
		public void RequestAddPort(string portName, CircuitType circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x1AA92E0", Offset = "0x1AA7CE0", VA = "0x181AA92E0", Slot = "22")]
		public override void HandleAddPortRequest(NodePortData newPortRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9390", Offset = "0x1AA7D90", VA = "0x181AA9390", Slot = "23")]
		public override void HandleRemovePortRequest(Guid portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x1AA8E50", Offset = "0x1AA7850", VA = "0x181AA8E50")]
		internal TPort AddPortLocal(string portName, CircuitTypeOrString circuitType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9440", Offset = "0x1AA7E40", VA = "0x181AA9440", Slot = "27")]
		public bool HasPort(string portName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9B10", Offset = "0x1AA8510", VA = "0x181AA9B10")]
		public bool TryGetPort(string portName, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9260", Offset = "0x1AA7C60", VA = "0x181AA9260")]
		private Guid GeneratePortId(string portName)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x1AA99A0", Offset = "0x1AA83A0", VA = "0x181AA99A0", Slot = "25")]
		public void MergeNamedGroup(IReadOnlyDictionary<string, CircuitType> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9480", Offset = "0x1AA7E80", VA = "0x181AA9480")]
		internal void MergeNamedGroup(IEnumerable<KeyValuePair<string, CircuitType>> incomingGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x1AA8FF0", Offset = "0x1AA79F0", VA = "0x181AA8FF0", Slot = "24")]
		public void ClearPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x1221370", Offset = "0x121FD70", VA = "0x181221370")]
		internal void OnBridgedPortRemoved<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x12213F0", Offset = "0x121FDF0", VA = "0x1812213F0")]
		internal (IEnumerable<Action>, IEnumerable<Node>) RemoveBridgedPortCore<TOtherPort>(TOtherPort otherRemovedPort) where TOtherPort : PortBase
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x1221340", Offset = "0x121FD40", VA = "0x181221340")]
		internal void OnBridgedPortAdded<TOtherPort>(TOtherPort otherAddedPort) where TOtherPort : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x11F4690", Offset = "0x11F3090", VA = "0x1811F4690")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public override bool CanSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x18DC650", Offset = "0x18DB050", VA = "0x1818DC650", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x3E2980", Offset = "0x3E1380", VA = "0x1803E2980", Slot = "9")]
		public sealed override Node GetNode(NodeConnection connection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x18DC4D0", Offset = "0x18DAED0", VA = "0x1818DC4D0")]
		public OutputPort(Guid portId, string portName, [Optional] CircuitTypeOrString? portType, [Optional] OutputPortGetDelegate outputPortGetDelegate, [Optional] OutputPortSetDelegate outputPortSetDelegate, [Optional] OutputPortGetReferencedNodeDelegate outputPortGetReferencedNodeDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x18DC3F0", Offset = "0x18DADF0", VA = "0x1818DC3F0", Slot = "13")]
		public override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x18DC490", Offset = "0x18DAE90", VA = "0x1818DC490", Slot = "15")]
		public override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x18DC3D0", Offset = "0x18DADD0", VA = "0x1818DC3D0", Slot = "16")]
		public override Node GetReferencedNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x18DC270", Offset = "0x18DAC70", VA = "0x1818DC270")]
		public NextExecutable GetExec()
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x18DC480", Offset = "0x18DAE80", VA = "0x1818DC480")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0x18DD8C0", Offset = "0x18DC2C0", VA = "0x1818DD8C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		internal bool IsDynamic
		{
			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF60", Offset = "0x3AE960", VA = "0x1803AFF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public bool IsInputPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0x805A90", Offset = "0x804490", VA = "0x180805A90")]
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
			[Cpp2IlInjected.Address(RVA = "0x3ADAB0", Offset = "0x3AC4B0", VA = "0x1803ADAB0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x39B5B0", Offset = "0x399FB0", VA = "0x18039B5B0", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x18DDAB0", Offset = "0x18DC4B0", VA = "0x1818DDAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x18DD820", Offset = "0x18DC220", VA = "0x1818DD820", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x18DDA10", Offset = "0x18DC410", VA = "0x1818DDA10", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<bool> OnIsConnectedChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0x18DD780", Offset = "0x18DC180", VA = "0x1818DD780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0x18DD970", Offset = "0x18DC370", VA = "0x1818DD970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract Node GetNode(NodeConnection connection);

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x18DD620", Offset = "0x18DC020", VA = "0x1818DD620")]
		protected PortBase(Guid portId, string portName, bool isInputPort, [Optional][CanBeNull] CircuitTypeOrString? circuitType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x18DD160", Offset = "0x18DBB60", VA = "0x1818DD160")]
		public void AddConnection(NodeConnection newConnection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x18DD460", Offset = "0x18DBE60", VA = "0x1818DD460")]
		public bool RemoveConnection(NodeConnection connection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x18DD3A0", Offset = "0x18DBDA0", VA = "0x1818DD3A0")]
		public void RemoveConnectionAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0xA10120", Offset = "0xA0EB20", VA = "0x180A10120", Slot = "12")]
		protected virtual void RaiseSpecificPortTypeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x18DD340", Offset = "0x18DBD40", VA = "0x1818DD340")]
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
		[Cpp2IlInjected.Address(RVA = "0x18DD540", Offset = "0x18DBF40", VA = "0x1818DD540", Slot = "17")]
		public NodePortData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x18DD220", Offset = "0x18DBC20", VA = "0x1818DD220", Slot = "5")]
		public void DeserializeFromProtobuf(NodePortData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0x18DD250", Offset = "0x18DBC50", VA = "0x1818DD250", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	internal static class PortBridge
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x1221F20", Offset = "0x1220920", VA = "0x181221F20")]
		internal static void BridgePortDelegates<TPortA, TPortB>(TPortA portA, TPortB portB) where TPortA : PortBase where TPortB : PortBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x18DDB00", Offset = "0x18DC500", VA = "0x1818DDB00")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public IEnumerable<PortGroupBase<TPort>> AllPortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x1AABEB0", Offset = "0x1AAA8B0", VA = "0x181AABEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public IEnumerable<TPort> AllPorts
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0x1AABF40", Offset = "0x1AAA940", VA = "0x181AABF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x1AABC70", Offset = "0x1AAA670", VA = "0x181AABC70")]
		public PortCollection(bool isInputCollection, Node node, PortCreationFactory<TPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAD80", Offset = "0x1AA9780", VA = "0x181AAAD80")]
		public IndexBasedPortGroup<TPort> RegisterIndexedPortGroup(Guid portGroupId, PortGroupSerialization serialization, CircuitTypeOrString elementType, string elementName = "Element", [Optional] string portGroupName, int minPortCount = 0, int maxPortCount = 64)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAEB0", Offset = "0x1AA98B0", VA = "0x181AAAEB0")]
		public NameBasedPortGroup<TPort> RegisterNameBasedPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAC70", Offset = "0x1AA9670", VA = "0x181AAAC70")]
		public ExecNameBasedPortGroup<TPort> RegisterExecNameBasedPortGroup(string execPortName, Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAB80", Offset = "0x1AA9580", VA = "0x181AAAB80")]
		public BasicPortGroup<TPort> RegisterBasicPortGroup(Guid portGroupId, PortGroupSerialization serialization, [Optional] string portGroupName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAB70", Offset = "0x1AA9570", VA = "0x181AAAB70")]
		private Dictionary<Guid, PortGroupBase<TPort>> GetPortGroupDictionary(PortGroupSerialization serialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9CD0", Offset = "0x1AA86D0", VA = "0x181AA9CD0")]
		private void AddPortGroup(PortGroupBase<TPort> newPortGroup, [Optional] string portGroupName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB6C0", Offset = "0x1AAA0C0", VA = "0x181AAB6C0")]
		public bool TryGetPort(Guid portGuid, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9CA0", Offset = "0x1AA86A0", VA = "0x181AA9CA0")]
		public void AddBuiltInPort(TPort port)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA890", Offset = "0x1AA9290", VA = "0x181AAA890", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB120", Offset = "0x1AA9B20", VA = "0x181AAB120", Slot = "6")]
		public PortCollectionData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "7")]
		protected virtual void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA360", Offset = "0x1AA8D60", VA = "0x181AAA360", Slot = "4")]
		public void DeserializeFromProtobuf([NotNull] PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "8")]
		protected virtual void DeserializeInternal(PortCollectionData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x1AA9F80", Offset = "0x1AA8980", VA = "0x181AA9F80")]
		private PortGroupBase<TPort> CreatePortGroupOnDeserialization(Guid portGroupId, PortGroupData protobufData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x11F49C0", Offset = "0x11F33C0", VA = "0x1811F49C0")]
		public bool TryGetPortGroup<T>(Guid portGroupId, out T portGroup) where T : PortGroupBase<TPort>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x1AAAFA0", Offset = "0x1AA99A0", VA = "0x181AAAFA0")]
		public void RemovePortGroup(Guid groupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public sealed class InputPortCollection : PortCollection<InputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x1688FD0", Offset = "0x16879D0", VA = "0x181688FD0")]
		public InputPortCollection(Node node, PortCreationFactory<InputPort> portCreationFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x1688D20", Offset = "0x1687720", VA = "0x181688D20", Slot = "7")]
		protected override void SerializeInternal(PortCollectionData collectionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x1688AD0", Offset = "0x16874D0", VA = "0x181688AD0", Slot = "8")]
		protected override void DeserializeInternal(PortCollectionData collectionData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	public sealed class OutputPortCollection : PortCollection<OutputPort>
	{
		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x18DB790", Offset = "0x18DA190", VA = "0x1818DB790")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AADD20", Offset = "0x1AAC720", VA = "0x181AADD20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public IReadOnlyList<TPort> OrderedPorts
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public PortGroupSerialization PortGroupSerialization
		{
			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0x3949C0", Offset = "0x3933C0", VA = "0x1803949C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC99E0", Offset = "0xEC83E0", VA = "0x180EC99E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		IReadOnlyCollection<PortBase> IPortGroup.Ports
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x11B8DD0", Offset = "0x11B77D0", VA = "0x1811B8DD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public Guid GroupId
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x61AC00", Offset = "0x619600", VA = "0x18061AC00", Slot = "14")]
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
			[Cpp2IlInjected.Address(RVA = "0x413C10", Offset = "0x412610", VA = "0x180413C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009BE")]
			[Cpp2IlInjected.Address(RVA = "0x470D60", Offset = "0x46F760", VA = "0x180470D60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public virtual bool CanAddPort
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x3A4230", Offset = "0x3A2C30", VA = "0x1803A4230", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<TPort> OnPortAdded
		{
			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x1AADBA0", Offset = "0x1AAC5A0", VA = "0x181AADBA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AADD40", Offset = "0x1AAC740", VA = "0x181AADD40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<TPort> OnPortRemoved
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x1AADC60", Offset = "0x1AAC660", VA = "0x181AADC60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x1AADE00", Offset = "0x1AAC800", VA = "0x181AADE00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x1AACA20", Offset = "0x1AAB420", VA = "0x181AACA20", Slot = "16")]
		public virtual bool CanRemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x1AAD950", Offset = "0x1AAC350", VA = "0x181AAD950")]
		protected PortGroupBase(PortCollection<TPort> parentCollection, Node node, Guid portGroupId, PortGroupSerialization portGroupSerialization, PortCreationFactory<TPort> portFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x1AAD8B0", Offset = "0x1AAC2B0", VA = "0x181AAD8B0")]
		public bool TryGetRegisteredPort(Guid portId, out TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x1AAC7B0", Offset = "0x1AAB1B0", VA = "0x181AAC7B0")]
		protected void AddGroupPort(TPort port, [Optional] bool? isDynamicOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x1AAD0B0", Offset = "0x1AABAB0", VA = "0x181AAD0B0")]
		protected bool RemoveGroupPort(TPort port)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x1AAD170", Offset = "0x1AABB70", VA = "0x181AAD170", Slot = "8")]
		public bool RemovePort(Guid portId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x1AAD750", Offset = "0x1AAC150", VA = "0x181AAD750", Slot = "17")]
		public PortGroupData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x1AAD450", Offset = "0x1AABE50", VA = "0x181AAD450", Slot = "18")]
		protected virtual void SerializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x1AACA60", Offset = "0x1AAB460", VA = "0x181AACA60", Slot = "10")]
		public void DeserializeFromProtobuf(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x1AACAC0", Offset = "0x1AAB4C0", VA = "0x181AACAC0", Slot = "19")]
		protected virtual void DeserializePortData(PortGroupData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x1AACD50", Offset = "0x1AAB750", VA = "0x181AACD50", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x1AAD200", Offset = "0x1AABC00", VA = "0x181AAD200", Slot = "20")]
		public void RequestAddPort(Guid portId, [Optional] string portName, [Optional] CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x1AAD350", Offset = "0x1AABD50", VA = "0x181AAD350", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x147D660", Offset = "0x147C060", VA = "0x18147D660")]
		protected PureNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x147D690", Offset = "0x147C090", VA = "0x18147D690")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AB0", Offset = "0x4124B0", VA = "0x180413AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B89C0", Offset = "0x3B73C0", VA = "0x1803B89C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1681F90", Offset = "0x1680990", VA = "0x181681F90")]
			get
			{
				return default(NextExecutable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x18DE330", Offset = "0x18DCD30", VA = "0x1818DE330")]
		protected SingleExecutableNode(CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x18DE5C0", Offset = "0x18DCFC0", VA = "0x1818DE5C0")]
		protected SingleExecutableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x18DE220", Offset = "0x18DCC20", VA = "0x1818DE220", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C0FE0", Offset = "0x3BF9E0", VA = "0x1803C0FE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Quaternion LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0x147A4D0", Offset = "0x1478ED0", VA = "0x18147A4D0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event OnLocalPositionChangedEvent OnLocalPositionChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E0")]
			[Cpp2IlInjected.Address(RVA = "0x147A390", Offset = "0x1478D90", VA = "0x18147A390")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E1")]
			[Cpp2IlInjected.Address(RVA = "0x147A4E0", Offset = "0x1478EE0", VA = "0x18147A4E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event OnLocalRotationChangedEvent OnLocalRotationChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60009E2")]
			[Cpp2IlInjected.Address(RVA = "0x147A430", Offset = "0x1478E30", VA = "0x18147A430")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60009E3")]
			[Cpp2IlInjected.Address(RVA = "0x147A580", Offset = "0x1478F80", VA = "0x18147A580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DF")]
		[Cpp2IlInjected.Address(RVA = "0x69AD60", Offset = "0x699760", VA = "0x18069AD60")]
		public CircuitObjectTransform(Guid circuitObjectId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x147A1E0", Offset = "0x1478BE0", VA = "0x18147A1E0")]
		public void SetLocalPosition(Vector3 newLocalPosition, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x147A2D0", Offset = "0x1478CD0", VA = "0x18147A2D0")]
		public void SetLocalRotation(Quaternion newLocalRotation, bool fireChangeEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x147A110", Offset = "0x1478B10", VA = "0x18147A110", Slot = "5")]
		public CircuitObjectTransformData SerializeToProtobuf()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x1479F60", Offset = "0x1478960", VA = "0x181479F60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x38FA60", Offset = "0x38E460", VA = "0x18038FA60")]
			public CircuitToken(string tokenName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0x147C030", Offset = "0x147AA30", VA = "0x18147C030", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x147BFE0", Offset = "0x147A9E0", VA = "0x18147BFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x147BDF0", Offset = "0x147A7F0", VA = "0x18147BDF0")]
		public bool AddToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x147BEC0", Offset = "0x147A8C0", VA = "0x18147BEC0")]
		public bool RemoveToken(CircuitToken token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x38D020", Offset = "0x38BA20", VA = "0x18038D020")]
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
		[Cpp2IlInjected.Address(RVA = "0x14AD40", Offset = "0x14A140", VA = "0x18014AD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x14AD40", Offset = "0x14A140", VA = "0x18014AD40")]
		public CircuitTeam(int backingTeamId = -1)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[Guid("21B7F027-68C6-4C8C-A5C3-81992622DE80")]
	public class ChangeCircuitObjectNameModificationHandler : CircuitObjectModificationHandlerBase<CircuitObject>
	{
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0x167D380", Offset = "0x167BD80", VA = "0x18167D380")]
		public ChangeCircuitObjectNameModificationHandler(CircuitObject modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0x167D2C0", Offset = "0x167BCC0", VA = "0x18167D2C0")]
		public ICircuitObjectModification CreateModification(string newNodeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x167D310", Offset = "0x167BD10", VA = "0x18167D310", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AA42C0", Offset = "0x1AA2CC0", VA = "0x181AA42C0", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x1040BA0", Offset = "0x103F5A0", VA = "0x181040BA0")]
		protected CircuitObjectModificationHandlerBase(T modifiedObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HandleModificationRequest(byte[] payload);

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x1AA41F0", Offset = "0x1AA2BF0", VA = "0x181AA41F0")]
		protected ICircuitObjectModification WithPayload(string payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4270", Offset = "0x1AA2C70", VA = "0x181AA4270")]
		protected ICircuitObjectModification WithPayload(IMessage payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4170", Offset = "0x1AA2B70", VA = "0x181AA4170")]
		protected ICircuitObjectModification WithPayload(byte[] payload)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x1AA4130", Offset = "0x1AA2B30", VA = "0x181AA4130")]
		protected static string ParseStringPayload(byte[] payload)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	public abstract class NodeModificationHandlerBase : CircuitObjectModificationHandlerBase<Node>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x168CC90", Offset = "0x168B690", VA = "0x18168CC90")]
		protected NodeModificationHandlerBase(Node modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	public abstract class NodeModificationHandlerBase<T> : CircuitObjectModificationHandlerBase<T> where T : Node
	{
		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x10314C0", Offset = "0x102FEC0", VA = "0x1810314C0")]
		protected NodeModificationHandlerBase(T modifiedNode)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	public abstract class EventModificationHandlerBase : CircuitObjectModificationHandlerBase<CircuitEventObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x16817B0", Offset = "0x16801B0", VA = "0x1816817B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AE0", Offset = "0x4124E0", VA = "0x180413AE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x391120", Offset = "0x38FB20", VA = "0x180391120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x168B6F0", Offset = "0x168A0F0", VA = "0x18168B6F0")]
		public ModificationBase(ICircuitObjectModificationHandler handler, CircuitObject modifiedObject, byte[] payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0", Slot = "6")]
		public byte[] GetPayload()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x168B6B0", Offset = "0x168A0B0", VA = "0x18168B6B0", Slot = "7")]
		public void Send()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[Guid("88EC6D1C-1F68-4A30-AD72-71A8AA1B933A")]
	public class PortDefaultValueModificationHandler : NodeModificationHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x168CC90", Offset = "0x168B690", VA = "0x18168CC90")]
		public PortDefaultValueModificationHandler(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x1690CF0", Offset = "0x168F6F0", VA = "0x181690CF0")]
		public ICircuitObjectModification CreateModification(Guid portId, CircuitSignal defaultSignal)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0x1690DC0", Offset = "0x168F7C0", VA = "0x181690DC0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x167FB60", Offset = "0x167E560", VA = "0x18167FB60")]
		public DebugLogNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0x167FA20", Offset = "0x167E420", VA = "0x18167FA20", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x167C420", Offset = "0x167AE20", VA = "0x18167C420")]
		public BranchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x167C260", Offset = "0x167AC60", VA = "0x18167C260", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x167CE10", Offset = "0x167B810", VA = "0x18167CE10")]
		public BreakTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x167CB50", Offset = "0x167B550", VA = "0x18167CB50")]
		private CircuitSignal GetReturn0(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x167CC60", Offset = "0x167B660", VA = "0x18167CC60")]
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
			[Cpp2IlInjected.Address(RVA = "0x16881E0", Offset = "0x1686BE0", VA = "0x1816881E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x16889F0", Offset = "0x16873F0", VA = "0x1816889F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x167D8D0", Offset = "0x167C2D0", VA = "0x18167D8D0")]
			public CircuitBoardModificationHandler(CircuitBoard modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x167D3D0", Offset = "0x167BDD0", VA = "0x18167D3D0")]
			public ICircuitObjectModification CreateExecGroupModification(string newExecGroupName, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x167D480", Offset = "0x167BE80", VA = "0x18167D480")]
			public ICircuitObjectModification DeleteExecGroupModification(Guid execGroupId, bool isInputGroup)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A32")]
			[Cpp2IlInjected.Address(RVA = "0x167D550", Offset = "0x167BF50", VA = "0x18167D550", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A4230", Offset = "0x3A2C30", VA = "0x1803A4230", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public override bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x3A4230", Offset = "0x3A2C30", VA = "0x1803A4230", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x167E9A0", Offset = "0x167D3A0", VA = "0x18167E9A0")]
		public CircuitBoard(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x167D920", Offset = "0x167C320", VA = "0x18167D920")]
		[EditableAddExecInput]
		internal ExecNameBasedPortGroup<InputPort> AddExecInput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x167DB20", Offset = "0x167C520", VA = "0x18167DB20")]
		[EditableAddExecOutput]
		internal ExecNameBasedPortGroup<OutputPort> AddExecOutput(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x167E400", Offset = "0x167CE00", VA = "0x18167E400")]
		internal void RemoveExecInput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x167E530", Offset = "0x167CF30", VA = "0x18167E530")]
		internal void RemoveExecOutput(Guid portGroupId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x167DD20", Offset = "0x167C720", VA = "0x18167DD20", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x167E110", Offset = "0x167CB10", VA = "0x18167E110", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x167E660", Offset = "0x167D060", VA = "0x18167E660", Slot = "24")]
		public override bool RequestAddInputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x167E700", Offset = "0x167D100", VA = "0x18167E700", Slot = "26")]
		public override bool RequestAddOutputGroup(string autoExecPortName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x167E7A0", Offset = "0x167D1A0", VA = "0x18167E7A0", Slot = "28")]
		public override bool RequestRemoveInputGroup(Guid groupId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x167E850", Offset = "0x167D250", VA = "0x18167E850", Slot = "30")]
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
			[Cpp2IlInjected.Address(RVA = "0x94D540", Offset = "0x94BF40", VA = "0x18094D540")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public virtual bool CanAddOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A39")]
			[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public virtual bool CanRemoveInputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public virtual bool CanRemoveOutputGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x167EBD0", Offset = "0x167D5D0", VA = "0x18167EBD0")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x167EB80", Offset = "0x167D580", VA = "0x18167EB80", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "24")]
		public virtual bool RequestAddInputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "26")]
		public virtual bool RequestAddOutputGroup(string autoExecPortNameIfRequired)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "28")]
		public virtual bool RequestRemoveInputGroup(Guid portGroup)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB40", Offset = "0x3A9540", VA = "0x1803AAB40", Slot = "30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B8990", Offset = "0x3B7390", VA = "0x1803B8990", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		protected HashSet<TEntryNode> CachedEntryNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0x1AA3B50", Offset = "0x1AA2550", VA = "0x181AA3B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		protected HashSet<TExitNode> CachedExitNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x1AA3E40", Offset = "0x1AA2840", VA = "0x181AA3E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public CircuitContext ChildContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x3B8990", Offset = "0x3B7390", VA = "0x1803B8990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x1AA3910", Offset = "0x1AA2310", VA = "0x181AA3910")]
		public CircuitContextNode(CircuitContext circuitContext, FunctionType type, Guid nodeId, Guid innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x1AA38A0", Offset = "0x1AA22A0", VA = "0x181AA38A0")]
		private void OnNodeAddedOrRemoved(CircuitContext context, Node modifiedNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x1AA37B0", Offset = "0x1AA21B0", VA = "0x181AA37B0")]
		private void DirtyCachedExitNodes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x1AA3850", Offset = "0x1AA2250", VA = "0x181AA3850", Slot = "16")]
		public sealed override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x1AA37C0", Offset = "0x1AA21C0", VA = "0x181AA37C0", Slot = "6")]
		protected override void DisposeInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "32")]
		protected virtual void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x1AA3800", Offset = "0x1AA2200", VA = "0x181AA3800", Slot = "22")]
		protected sealed override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		protected abstract NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope);

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x1AA2EF0", Offset = "0x1AA18F0", VA = "0x181AA2EF0", Slot = "34")]
		protected virtual bool AddInnerEntry(InputPort execInput, out TEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x1AA3320", Offset = "0x1AA1D20", VA = "0x181AA3320", Slot = "35")]
		internal virtual bool AddInnerExit(OutputPort execOutput, out TExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x1AA3770", Offset = "0x1AA2170", VA = "0x181AA3770", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AB0", Offset = "0x4124B0", VA = "0x180413AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B89C0", Offset = "0x3B73C0", VA = "0x1803B89C0", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B8990", Offset = "0x3B7390", VA = "0x1803B8990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0x3B6B70", Offset = "0x3B5570", VA = "0x1803B6B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AA8100", Offset = "0x1AA6B00", VA = "0x181AA8100")]
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
			[Cpp2IlInjected.Address(RVA = "0x413BA0", Offset = "0x4125A0", VA = "0x180413BA0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x1687FA0", Offset = "0x16869A0", VA = "0x181687FA0")]
		protected InnerContextEntryNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x1687F20", Offset = "0x1686920", VA = "0x181687F20", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x413B70", Offset = "0x412570", VA = "0x180413B70", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x1688950", Offset = "0x1687350", VA = "0x181688950")]
		protected InnerContextExitNodeBase(CircuitContext circuitContext, FunctionType type, Guid nodeId, string inputExecPortName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x16888B0", Offset = "0x16872B0", VA = "0x1816888B0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x413A90", Offset = "0x412490", VA = "0x180413A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x1680190", Offset = "0x167EB90", VA = "0x181680190")]
		public DelayNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x167FEC0", Offset = "0x167E8C0", VA = "0x18167FEC0", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x167FDA0", Offset = "0x167E7A0", VA = "0x18167FDA0", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x167FFD0", Offset = "0x167E9D0", VA = "0x18167FFD0", Slot = "23")]
		public void HandleEvent(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x167FE50", Offset = "0x167E850", VA = "0x18167FE50")]
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
			[Cpp2IlInjected.Address(RVA = "0x1682870", Offset = "0x1681270", VA = "0x181682870")]
			public EventRegistrationNodeModificationHandler(EventNodeBase modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x1682780", Offset = "0x1681180", VA = "0x181682780")]
			public ICircuitObjectModification CreateSetRegistrationModification(CircuitEventBus.EventRegistration eventRegistration)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0x16827E0", Offset = "0x16811E0", VA = "0x1816827E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AB0", Offset = "0x4124B0", VA = "0x180413AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x1681C20", Offset = "0x1680620", VA = "0x181681C20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices();

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x1681B70", Offset = "0x1680570", VA = "0x181681B70")]
		protected EventNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x1681800", Offset = "0x1680200", VA = "0x181681800", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x1681890", Offset = "0x1680290", VA = "0x181681890")]
		private void RefreshPorts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "25")]
		protected virtual void RegisterNewEventRegistration([NotNull] CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x388C10", Offset = "0x387610", VA = "0x180388C10", Slot = "26")]
		protected virtual void UnregisterOldEventRegistration([NotNull] CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x1681AC0", Offset = "0x16804C0", VA = "0x181681AC0")]
		protected void SetEventRegistrationFromData(EventRegistrationData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId);

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x1681A00", Offset = "0x1680400", VA = "0x181681A00")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AA0", Offset = "0x4124A0", VA = "0x180413AA0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x1682500", Offset = "0x1680F00", VA = "0x181682500")]
		public EventReceiverNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A77")]
		[Cpp2IlInjected.Address(RVA = "0x1681F90", Offset = "0x1680990", VA = "0x181681F90", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x16823E0", Offset = "0x1680DE0", VA = "0x1816823E0", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x1681EF0", Offset = "0x16808F0", VA = "0x181681EF0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x1682470", Offset = "0x1680E70", VA = "0x181682470", Slot = "26")]
		protected override void UnregisterOldEventRegistration(CircuitEventBus.EventRegistration oldEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x1681FE0", Offset = "0x16809E0", VA = "0x181681FE0", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x1682030", Offset = "0x1680A30", VA = "0x181682030", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0x16823B0", Offset = "0x1680DB0", VA = "0x1816823B0", Slot = "25")]
		protected override void RegisterNewEventRegistration(CircuitEventBus.EventRegistration newEventRegistration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x1682060", Offset = "0x1680A60", VA = "0x181682060", Slot = "28")]
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
			[Cpp2IlInjected.Address(RVA = "0x413A90", Offset = "0x412490", VA = "0x180413A90", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public InputPort InputExecPort
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0x413AA0", Offset = "0x4124A0", VA = "0x180413AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E16F0", Offset = "0x3E00F0", VA = "0x1803E16F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x1682E70", Offset = "0x1681870", VA = "0x181682E70")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId, bool sendSyncEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x1683240", Offset = "0x1681C40", VA = "0x181683240")]
		public EventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x1682CF0", Offset = "0x16816F0", VA = "0x181682CF0", Slot = "24")]
		public override IEnumerable<CircuitEventBus.EventRegistration> GetEventRegistrationChoices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x1682CA0", Offset = "0x16816A0", VA = "0x181682CA0", Slot = "27")]
		protected override CircuitEventBus.EventRegistration FindRegistration(Guid serializedContextId, Guid serializedEventId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x1682C40", Offset = "0x1681640", VA = "0x181682C40", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x1682960", Offset = "0x1681360", VA = "0x181682960")]
		protected void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x1682D20", Offset = "0x1681720", VA = "0x181682D20", Slot = "28")]
		protected virtual void SendEventInternal(CircuitEvent circuitEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x1682D40", Offset = "0x1681740", VA = "0x181682D40", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData myNodeData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x16828C0", Offset = "0x16812C0", VA = "0x1816828C0", Slot = "19")]
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
				[Cpp2IlInjected.Address(RVA = "0x38AAF0", Offset = "0x3894F0", VA = "0x18038AAF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x1694250", Offset = "0x1692C50", VA = "0x181694250")]
			public SyncedEventSenderModificationHandler(SynchedEventSenderNode modifiedNode)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x1694180", Offset = "0x1692B80", VA = "0x181694180")]
			public ICircuitObjectModification CreateChangeTargetModification(SynchronizedCircuitContext.SyncedEventTargets syncedEventTargets)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x1694200", Offset = "0x1692C00", VA = "0x181694200", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F180", Offset = "0x41DB80", VA = "0x18041F180")]
			get
			{
				return default(SynchronizedCircuitContext.SyncedEventTargets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x16947E0", Offset = "0x16931E0", VA = "0x1816947E0")]
		public SynchedEventSenderNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x16947A0", Offset = "0x16931A0", VA = "0x1816947A0", Slot = "28")]
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
			[Cpp2IlInjected.Address(RVA = "0x16885A0", Offset = "0x1686FA0", VA = "0x1816885A0")]
			public InnerContextEntryNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA3")]
			[Cpp2IlInjected.Address(RVA = "0x1688040", Offset = "0x1686A40", VA = "0x181688040", Slot = "21")]
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
				[Cpp2IlInjected.Address(RVA = "0x101D780", Offset = "0x101C180", VA = "0x18101D780")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000AA8")]
				[Cpp2IlInjected.Address(RVA = "0x101C2C0", Offset = "0x101ACC0", VA = "0x18101C2C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0x167CA60", Offset = "0x167B460", VA = "0x18167CA60")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0x167C860", Offset = "0x167B260", VA = "0x18167C860", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0x167C960", Offset = "0x167B360", VA = "0x18167C960")]
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
			[Cpp2IlInjected.Address(RVA = "0x4139D0", Offset = "0x4123D0", VA = "0x1804139D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E6920", Offset = "0x3E5320", VA = "0x1803E6920")]
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
			[Cpp2IlInjected.Address(RVA = "0x413A00", Offset = "0x412400", VA = "0x180413A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x1684D90", Offset = "0x1683790", VA = "0x181684D90")]
		public ForeachNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x1684C40", Offset = "0x1683640", VA = "0x181684C40", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x1684790", Offset = "0x1683190", VA = "0x181684790", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x1684820", Offset = "0x1683220", VA = "0x181684820", Slot = "33")]
		protected override NextExecutable ExecuteInnerScope(InputPort execStartPort, IExecutionScope outerExecutionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x1684660", Offset = "0x1683060", VA = "0x181684660", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x1684700", Offset = "0x1683100", VA = "0x181684700", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x1684B60", Offset = "0x1683560", VA = "0x181684B60", Slot = "21")]
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
			[Cpp2IlInjected.Address(RVA = "0x16882C0", Offset = "0x1686CC0", VA = "0x1816882C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x101D780", Offset = "0x101C180", VA = "0x18101D780")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000ABF")]
				[Cpp2IlInjected.Address(RVA = "0x101C2C0", Offset = "0x101ACC0", VA = "0x18101C2C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x167C970", Offset = "0x167B370", VA = "0x18167C970")]
			public BreakExitNode(CircuitContext circuitContext, Guid nodeId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(RVA = "0x167C8E0", Offset = "0x167B2E0", VA = "0x18167C8E0", Slot = "22")]
			protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
			{
				return default(NextExecutable);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0x167C960", Offset = "0x167B360", VA = "0x18167C960")]
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
			[Cpp2IlInjected.Address(RVA = "0x4139D0", Offset = "0x4123D0", VA = "0x1804139D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E6920", Offset = "0x3E5320", VA = "0x1803E6920")]
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
			[Cpp2IlInjected.Address(RVA = "0x413A60", Offset = "0x412460", VA = "0x180413A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x4139F0", Offset = "0x4123F0", VA = "0x1804139F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x1684070", Offset = "0x1682A70", VA = "0x181684070")]
		public ForNode(CircuitContext circuitContext, Guid nodeId, Guid? innerContextId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x1683EF0", Offset = "0x16828F0", VA = "0x181683EF0", Slot = "32")]
		protected override void InitializeChildContext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x1683C10", Offset = "0x1682610", VA = "0x181683C10", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x1683AE0", Offset = "0x16824E0", VA = "0x181683AE0", Slot = "34")]
		protected override bool AddInnerEntry(InputPort execInput, out InnerContextEntryNode newInnerEntryNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x1683B80", Offset = "0x1682580", VA = "0x181683B80", Slot = "35")]
		internal override bool AddInnerExit(OutputPort execOutput, out BreakExitNode newInnerExitNode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x1683CA0", Offset = "0x16826A0", VA = "0x181683CA0", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x16859D0", Offset = "0x16843D0", VA = "0x1816859D0")]
		public GetElementNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x16857A0", Offset = "0x16841A0", VA = "0x1816857A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1685EA0", Offset = "0x16848A0", VA = "0x181685EA0")]
		public GetListCountNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x1685E20", Offset = "0x1684820", VA = "0x181685E20", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x1686F00", Offset = "0x1685900", VA = "0x181686F00")]
		public HasAuthorityNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x1686DA0", Offset = "0x16857A0", VA = "0x181686DA0", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x168AB90", Offset = "0x1689590", VA = "0x18168AB90")]
		public MakeListNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x168AA60", Offset = "0x1689460", VA = "0x18168AA60", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x168B130", Offset = "0x1689B30", VA = "0x18168B130")]
		public MakeTuple(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x168AF40", Offset = "0x1689940", VA = "0x18168AF40")]
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
		[Cpp2IlInjected.Address(RVA = "0x216530", Offset = "0x215930", VA = "0x180216530")]
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
		[Cpp2IlInjected.Address(RVA = "0x16926A0", Offset = "0x16910A0", VA = "0x1816926A0")]
		protected RandomNumberGeneratorNode(CircuitContext circuitContext, CircuitType numberType, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x16924B0", Offset = "0x1690EB0", VA = "0x1816924B0", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		protected abstract CircuitSignal GenerateRandom(CircuitSignal fromSignal, CircuitSignal toSignal);

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x16925B0", Offset = "0x1690FB0", VA = "0x1816925B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1692290", Offset = "0x1690C90", VA = "0x181692290")]
		public RandomIntegerGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x16921B0", Offset = "0x1690BB0", VA = "0x1816921B0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x1691FB0", Offset = "0x16909B0", VA = "0x181691FB0")]
		public RandomFloatGeneratorNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0x1691E70", Offset = "0x1690870", VA = "0x181691E70", Slot = "24")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B8990", Offset = "0x3B7390", VA = "0x1803B8990")]
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
			[Cpp2IlInjected.Address(RVA = "0x413A90", Offset = "0x412490", VA = "0x180413A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x1692F00", Offset = "0x1691900", VA = "0x181692F00")]
		public SetValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x1692DF0", Offset = "0x16917F0", VA = "0x181692DF0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x1693310", Offset = "0x1691D10", VA = "0x181693310")]
		public ShowNotificationNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x16931D0", Offset = "0x1691BD0", VA = "0x1816931D0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x1AAF040", Offset = "0x1AADA40", VA = "0x181AAF040")]
		public SwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x1AAE4D0", Offset = "0x1AACED0", VA = "0x181AAE4D0", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x1AADEC0", Offset = "0x1AAC8C0", VA = "0x181AADEC0")]
		protected Dictionary<T, OutputPort> BuildCaseMap()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x1AAE590", Offset = "0x1AACF90", VA = "0x181AAE590", Slot = "18")]
		protected sealed override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(Slot = "25")]
		protected abstract SwitchNodeData SerializeCaseLables(IEnumerable<T> caseLables);

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x1AAE330", Offset = "0x1AACD30", VA = "0x181AAE330", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0x1689D70", Offset = "0x1688770", VA = "0x181689D70", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0x1689C10", Offset = "0x1688610", VA = "0x181689C10", Slot = "24")]
		protected override int GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x1689CF0", Offset = "0x16886F0", VA = "0x181689CF0")]
		public IntSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(RVA = "0x1689C70", Offset = "0x1688670", VA = "0x181689C70", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<int> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x3E2980", Offset = "0x3E1380", VA = "0x1803E2980", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0x1693F90", Offset = "0x1692990", VA = "0x181693F90", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(RVA = "0x1693E30", Offset = "0x1692830", VA = "0x181693E30", Slot = "24")]
		protected override string GetSwitchPortValue(InputPort switchPort, IExecutionScope executionScope)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(RVA = "0x1693F10", Offset = "0x1692910", VA = "0x181693F10")]
		public StringSwitchNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(RVA = "0x1693E90", Offset = "0x1692890", VA = "0x181693E90", Slot = "25")]
		protected override SwitchNodeData SerializeCaseLables(IEnumerable<string> caseLabels)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x43F6D0", Offset = "0x43E0D0", VA = "0x18043F6D0", Slot = "26")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B8990", Offset = "0x3B7390", VA = "0x1803B8990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x168BE70", Offset = "0x168A870", VA = "0x18168BE70")]
		public MultiInputBooleanLogicNode(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x168BC70", Offset = "0x168A670", VA = "0x18168BC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x167C000", Offset = "0x167AA00", VA = "0x18167C000")]
		public AndNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x167BF10", Offset = "0x167A910", VA = "0x18167BF10", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x1690A90", Offset = "0x168F490", VA = "0x181690A90")]
		public OrNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x16909A0", Offset = "0x168F3A0", VA = "0x1816909A0", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x168C600", Offset = "0x168B000", VA = "0x18168C600")]
		public NANDNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x168C510", Offset = "0x168AF10", VA = "0x18168C510", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x168C790", Offset = "0x168B190", VA = "0x18168C790")]
		public NORNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x168C6A0", Offset = "0x168B0A0", VA = "0x18168C6A0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AB0", Offset = "0x4124B0", VA = "0x180413AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x168F430", Offset = "0x168DE30", VA = "0x18168F430")]
		public NotNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x168F300", Offset = "0x168DD00", VA = "0x18168F300")]
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
		[Cpp2IlInjected.Address(RVA = "0x1687440", Offset = "0x1685E40", VA = "0x181687440")]
		public IfExpressionNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x1687270", Offset = "0x1685C70", VA = "0x181687270")]
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
		[Cpp2IlInjected.Address(RVA = "0x168A4C0", Offset = "0x1688EC0", VA = "0x18168A4C0")]
		public MakeDictionaryNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x168A370", Offset = "0x1688D70", VA = "0x18168A370")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AB0", Offset = "0x4124B0", VA = "0x180413AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x167B790", Offset = "0x167A190", VA = "0x18167B790")]
		public AbsoluteValueNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x167B5B0", Offset = "0x1679FB0", VA = "0x18167B5B0", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x167B4C0", Offset = "0x1679EC0", VA = "0x18167B4C0")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x167B3C0", Offset = "0x1679DC0", VA = "0x18167B3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x167BE70", Offset = "0x167A870", VA = "0x18167BE70")]
		public AddNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x167BCA0", Offset = "0x167A6A0", VA = "0x18167BCA0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x167BC90", Offset = "0x167A690", VA = "0x18167BC90", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x1680A90", Offset = "0x167F490", VA = "0x181680A90")]
		public DivideNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x1680860", Offset = "0x167F260", VA = "0x181680860", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x1680A60", Offset = "0x167F460", VA = "0x181680A60")]
		private static int SafeDivide(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x16806A0", Offset = "0x167F0A0", VA = "0x1816806A0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x1680A40", Offset = "0x167F440", VA = "0x181680A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x168BBD0", Offset = "0x168A5D0", VA = "0x18168BBD0")]
		public ModuloNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x168B9C0", Offset = "0x168A3C0", VA = "0x18168B9C0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x168BBB0", Offset = "0x168A5B0", VA = "0x18168BBB0")]
		private static int SafeModulo(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x168B7E0", Offset = "0x168A1E0", VA = "0x18168B7E0", Slot = "23")]
		protected override float CalculateFloatValue(IList<float> signals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x168BB90", Offset = "0x168A590", VA = "0x18168BB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x168C470", Offset = "0x168AE70", VA = "0x18168C470")]
		public MultiplyNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x168C2E0", Offset = "0x168ACE0", VA = "0x18168C2E0", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x168C130", Offset = "0x168AB30", VA = "0x18168C130", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16910E0", Offset = "0x168FAE0", VA = "0x1816910E0")]
		public PowerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x1691030", Offset = "0x168FA30", VA = "0x181691030", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x1690F80", Offset = "0x168F980", VA = "0x181690F80", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16940E0", Offset = "0x1692AE0", VA = "0x1816940E0")]
		public SubtractNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x1694060", Offset = "0x1692A60", VA = "0x181694060", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x1693FE0", Offset = "0x16929E0", VA = "0x181693FE0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x168B550", Offset = "0x1689F50", VA = "0x18168B550")]
		public MaxNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x168B540", Offset = "0x1689F40", VA = "0x18168B540", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x168B530", Offset = "0x1689F30", VA = "0x18168B530", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x168B610", Offset = "0x168A010", VA = "0x18168B610")]
		public MinNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x168B600", Offset = "0x168A000", VA = "0x18168B600", Slot = "22")]
		protected override int CalculateIntValue(IList<int> signals)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x168B5F0", Offset = "0x1689FF0", VA = "0x18168B5F0", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B8990", Offset = "0x3B7390", VA = "0x1803B8990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168EF60", VA = "0x181690560")]
		public NumberNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName, int minPortCount, int maxPortCount = int.MaxValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x1690380", Offset = "0x168ED80", VA = "0x181690380", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x16901D0", Offset = "0x168EBD0", VA = "0x1816901D0")]
		private CircuitSignal GetInt32Return(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x1690070", Offset = "0x168EA70", VA = "0x181690070")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B89C0", Offset = "0x3B73C0", VA = "0x1803B89C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x16939A0", Offset = "0x16923A0", VA = "0x1816939A0")]
		public StringFormatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x1693580", Offset = "0x1691F80", VA = "0x181693580")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B8990", Offset = "0x3B7390", VA = "0x1803B8990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x1683450", Offset = "0x1681E50", VA = "0x181683450")]
		protected ExternalVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x1683360", Offset = "0x1681D60", VA = "0x181683360", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x1683270", Offset = "0x1681C70", VA = "0x181683270", Slot = "26")]
		protected override CircuitSignal Get(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	public abstract class ExternalVariableNode<TVal> : ExternalVariableNode
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x1AA5130", Offset = "0x1AA3B30", VA = "0x181AA5130")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BC8F0", Offset = "0x4BB2F0", VA = "0x1804BC8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0x4BD860", Offset = "0x4BC260", VA = "0x1804BD860")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public string SymbolName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B64")]
			[Cpp2IlInjected.Address(RVA = "0x413A90", Offset = "0x412490", VA = "0x180413A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B65")]
			[Cpp2IlInjected.Address(RVA = "0x4CB930", Offset = "0x4CA330", VA = "0x1804CB930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		protected Memory.IMemoryHandle MemoryHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000B66")]
			[Cpp2IlInjected.Address(RVA = "0x413AA0", Offset = "0x4124A0", VA = "0x180413AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x1687C70", Offset = "0x1686670", VA = "0x181687C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		internal Guid MemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x1687B70", Offset = "0x1686570", VA = "0x181687B70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		protected Guid DefaultMemoryAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x1687A80", Offset = "0x1686480", VA = "0x181687A80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x16879E0", Offset = "0x16863E0", VA = "0x1816879E0")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x1687920", Offset = "0x1686320", VA = "0x181687920", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AA6FC0", Offset = "0x1AA59C0", VA = "0x181AA6FC0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		private string AllocateVariableName
		{
			[Cpp2IlInjected.Token(Token = "0x6000B6E")]
			[Cpp2IlInjected.Address(RVA = "0x1AA7420", Offset = "0x1AA5E20", VA = "0x181AA7420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x1AA6E00", Offset = "0x1AA5800", VA = "0x181AA6E00")]
		protected InMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x1AA5F70", Offset = "0x1AA4970", VA = "0x181AA5F70", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract Memory.IMemoryHandle Allocate(Guid defaultAddress, string variableName);

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x1AA65F0", Offset = "0x1AA4FF0", VA = "0x181AA65F0", Slot = "7")]
		internal override void SetNameLocal(string newName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x1AA5D00", Offset = "0x1AA4700", VA = "0x181AA5D00", Slot = "8")]
		public override bool CanChangeNameTo(string newName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x1AA62E0", Offset = "0x1AA4CE0", VA = "0x181AA62E0", Slot = "18")]
		protected override void SerializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x1AA5DD0", Offset = "0x1AA47D0", VA = "0x181AA5DD0", Slot = "19")]
		protected override void DeserializeInternal(CircuitNodeData protobufData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x1AA6AB0", Offset = "0x1AA54B0", VA = "0x181AA6AB0", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x1AA5EE0", Offset = "0x1AA48E0", VA = "0x181AA5EE0", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x167C0A0", Offset = "0x167AAA0", VA = "0x18167C0A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1689A50", Offset = "0x1688450", VA = "0x181689A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x16834F0", Offset = "0x1681EF0", VA = "0x1816834F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16934F0", Offset = "0x1691EF0", VA = "0x1816934F0")]
		public StringExternalVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D5")]
	[NodeTag("Networking", new string[] { })]
	public abstract class SyncedInMemoryVariableNode<T> : InMemoryVariableNode<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x1AAFDD0", Offset = "0x1AAE7D0", VA = "0x181AAFDD0")]
		protected SyncedInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId, CircuitType portType, MemoryDelegates.ValueGetter getter, MemoryDelegates.ValueSetter setter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D6")]
	[Guid("1A5331BC-5025-487E-898C-3C49EE715664")]
	public class IntInMemoryVariableNode : InMemoryVariableNode<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x1689AE0", Offset = "0x16884E0", VA = "0x181689AE0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x1689B30", Offset = "0x1688530", VA = "0x181689B30")]
		public IntInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D7")]
	[Guid("3EE1EDFE-5520-4714-862B-98AF90F6E3DA")]
	public class PlayerInMemoryVariableNode : InMemoryVariableNode<CircuitPlayer>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B80")]
		[Cpp2IlInjected.Address(RVA = "0x1689AE0", Offset = "0x16884E0", VA = "0x181689AE0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x1690BE0", Offset = "0x168F5E0", VA = "0x181690BE0")]
		public PlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B82")]
		[Cpp2IlInjected.Address(RVA = "0x1690B90", Offset = "0x168F590", VA = "0x181690B90")]
		private static bool SetPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B83")]
		[Cpp2IlInjected.Address(RVA = "0x1690B30", Offset = "0x168F530", VA = "0x181690B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1694500", Offset = "0x1692F00", VA = "0x181694500", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B85")]
		[Cpp2IlInjected.Address(RVA = "0x1694970", Offset = "0x1693370", VA = "0x181694970")]
		public SynchedPlayerInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B86")]
		[Cpp2IlInjected.Address(RVA = "0x1694920", Offset = "0x1693320", VA = "0x181694920")]
		private static bool SetSynchedPlayer(Memory memory, Guid memoryAddress, CircuitSignal newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B87")]
		[Cpp2IlInjected.Address(RVA = "0x16948C0", Offset = "0x16932C0", VA = "0x1816948C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1694500", Offset = "0x1692F00", VA = "0x181694500", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x1694550", Offset = "0x1692F50", VA = "0x181694550")]
		public SyncedInMemoryIntVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DA")]
	[Guid("DCE27FE2-ABC2-4A6A-9C4E-5D829A5B83A6")]
	public class FloatInMemoryVariableNode : InMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x1683580", Offset = "0x1681F80", VA = "0x181683580", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(RVA = "0x16835D0", Offset = "0x1681FD0", VA = "0x1816835D0")]
		public FloatInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DB")]
	[Guid("56DCF860-9C74-4213-8859-45ABA0B96D43")]
	public class SyncedInMemoryFloatVariableNode : SyncedInMemoryVariableNode<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x16943D0", Offset = "0x1692DD0", VA = "0x1816943D0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x1694420", Offset = "0x1692E20", VA = "0x181694420")]
		public SyncedInMemoryFloatVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DC")]
	[Guid("8065D557-B6CC-4DD1-8CFA-B7481FE7BCF1")]
	public class BoolInMemoryVariableNode : InMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x167C130", Offset = "0x167AB30", VA = "0x18167C130", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x167C180", Offset = "0x167AB80", VA = "0x18167C180")]
		public BoolInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[Guid("1E2CA8E7-037F-4A1A-82A7-62B81928B6A4")]
	public class SyncedInMemoryBoolVariableNode : SyncedInMemoryVariableNode<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x16942A0", Offset = "0x1692CA0", VA = "0x1816942A0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x16942F0", Offset = "0x1692CF0", VA = "0x1816942F0")]
		public SyncedInMemoryBoolVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[Guid("797913DF-1BCF-4280-8666-F17D7782CEBB")]
	public class StringInMemoryVariableNode : InMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1693CC0", Offset = "0x16926C0", VA = "0x181693CC0", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x1693D50", Offset = "0x1692750", VA = "0x181693D50")]
		public StringInMemoryVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	[Guid("62F1B8B1-F1D3-4CEB-B0E9-57C4915BF401")]
	public class SyncedInMemoryStringVariableNode : SyncedInMemoryVariableNode<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x1694630", Offset = "0x1693030", VA = "0x181694630", Slot = "29")]
		protected override Memory.IMemoryHandle Allocate(Guid address, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x16946C0", Offset = "0x16930C0", VA = "0x1816946C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B8990", Offset = "0x3B7390", VA = "0x1803B8990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x18DFD60", Offset = "0x18DE760", VA = "0x1818DFD60")]
		public ValueChangedNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x18DF890", Offset = "0x18DE290", VA = "0x1818DF890", Slot = "20")]
		protected internal override (IEnumerable<Action>, IEnumerable<Node>) DisposeWithEvents()
		{
			return default((IEnumerable<Action>, IEnumerable<Node>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x18DFA10", Offset = "0x18DE410", VA = "0x1818DFA10", Slot = "22")]
		protected override NextExecutable Execute(InputPort execStartPort, IExecutionScope executionScope)
		{
			return default(NextExecutable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x18DFBB0", Offset = "0x18DE5B0", VA = "0x1818DFBB0", Slot = "23")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x18DFC20", Offset = "0x18DE620", VA = "0x1818DFC20")]
		private void UnregisterListeningNode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9C")]
		[Cpp2IlInjected.Address(RVA = "0x18DFA60", Offset = "0x18DE460", VA = "0x1818DFA60")]
		private void OnIsConnectedChanged(bool isConnected)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9D")]
		[Cpp2IlInjected.Address(RVA = "0x18DFA60", Offset = "0x18DE460", VA = "0x1818DFA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B89C0", Offset = "0x3B73C0", VA = "0x1803B89C0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(RVA = "0x18E0490", Offset = "0x18DEE90", VA = "0x1818E0490")]
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
		[Cpp2IlInjected.Address(RVA = "0x18E01C0", Offset = "0x18DEBC0", VA = "0x1818E01C0", Slot = "27")]
		public void OnVariableChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x18E0370", Offset = "0x18DED70", VA = "0x1818E0370", Slot = "22")]
		public void RegisterChangeListener(IVariableChangeListener changeListener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x18E03D0", Offset = "0x18DEDD0", VA = "0x1818E03D0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x18DCEF0", Offset = "0x18DB8F0", VA = "0x1818DCEF0")]
		protected ParsingNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x18DCC80", Offset = "0x18DB680", VA = "0x1818DCC80", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x18DCB10", Offset = "0x18DB510", VA = "0x1818DCB10")]
		public ParseIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x18DCA90", Offset = "0x18DB490", VA = "0x1818DCA90", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x18DC920", Offset = "0x18DB320", VA = "0x1818DC920")]
		public ParseFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x18DC8A0", Offset = "0x18DB2A0", VA = "0x1818DC8A0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x18DC730", Offset = "0x18DB130", VA = "0x1818DC730")]
		public ParseBoolNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x18DC660", Offset = "0x18DB060", VA = "0x1818DC660", Slot = "25")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AD0", Offset = "0x4124D0", VA = "0x180413AD0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AB0", Offset = "0x4124B0", VA = "0x180413AB0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x18DE720", Offset = "0x18DD120", VA = "0x1818DE720")]
		protected TypeConversionNode(CircuitTypeOrString inType, CircuitTypeOrString outType, CircuitContext circuitContext, FunctionType type, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x18DE5F0", Offset = "0x18DCFF0", VA = "0x1818DE5F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x18DB150", Offset = "0x18D9B50", VA = "0x1818DB150")]
		public IntToFloatNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x18DB110", Offset = "0x18D9B10", VA = "0x1818DB110", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x1683910", Offset = "0x1682310", VA = "0x181683910")]
		protected FloatToIntConversionNodeBase(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x1683780", Offset = "0x1682180", VA = "0x181683780", Slot = "24")]
		protected sealed override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x16836B0", Offset = "0x16820B0", VA = "0x1816836B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x167D2A0", Offset = "0x167BCA0", VA = "0x18167D2A0")]
		public FloorToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x1683A80", Offset = "0x1682480", VA = "0x181683A80", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x167D2A0", Offset = "0x167BCA0", VA = "0x18167D2A0")]
		public CeilToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x167D240", Offset = "0x167BC40", VA = "0x18167D240", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x167D2A0", Offset = "0x167BCA0", VA = "0x18167D2A0")]
		public RoundToIntNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x18DE1C0", Offset = "0x18DCBC0", VA = "0x1818DE1C0", Slot = "25")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B89C0", Offset = "0x3B73C0", VA = "0x1803B89C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x168FB30", Offset = "0x168E530", VA = "0x18168FB30")]
		public NumberComparisonNodeBase(CircuitContext circuitContext, Guid nodeId, string outputPortName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x168F920", Offset = "0x168E320", VA = "0x18168F920", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x168F6E0", Offset = "0x168E0E0", VA = "0x18168F6E0")]
		private CircuitSignal CalculateReturnValueFloat(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x168F800", Offset = "0x168E200", VA = "0x18168F800")]
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
		[Cpp2IlInjected.Address(RVA = "0x1686BE0", Offset = "0x16855E0", VA = "0x181686BE0")]
		public GreaterThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x1686B50", Offset = "0x1685550", VA = "0x181686B50", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x1686B40", Offset = "0x1685540", VA = "0x181686B40", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x1689FB0", Offset = "0x16889B0", VA = "0x181689FB0")]
		public LessThanNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x1689F20", Offset = "0x1688920", VA = "0x181689F20", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x1689F10", Offset = "0x1688910", VA = "0x181689F10", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x1686D10", Offset = "0x1685710", VA = "0x181686D10")]
		public GreaterThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x1686C70", Offset = "0x1685670", VA = "0x181686C70", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x1686D00", Offset = "0x1685700", VA = "0x181686D00", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x168A0E0", Offset = "0x1688AE0", VA = "0x18168A0E0")]
		public LessThanOrEqualNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x168A040", Offset = "0x1688A40", VA = "0x18168A040", Slot = "22")]
		protected override bool CalculateReturnValueInternal(float signalA, float signalB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x168A0D0", Offset = "0x1688AD0", VA = "0x18168A0D0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x16813C0", Offset = "0x167FDC0", VA = "0x1816813C0")]
		public EqualsNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x1681240", Offset = "0x167FC40", VA = "0x181681240", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x1681270", Offset = "0x167FC70", VA = "0x181681270", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x1680C30", Offset = "0x167F630", VA = "0x181680C30")]
		private OutputPortGetDelegate GetDelegateForType(CircuitType specificType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x1681030", Offset = "0x167FA30", VA = "0x181681030")]
		private CircuitSignal GetReferenceEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x1681130", Offset = "0x167FB30", VA = "0x181681130")]
		private CircuitSignal GetStringEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x1680DD0", Offset = "0x167F7D0", VA = "0x181680DD0")]
		private CircuitSignal GetFloatEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x1680F30", Offset = "0x167F930", VA = "0x181680F30")]
		private CircuitSignal GetIntEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x1680B30", Offset = "0x167F530", VA = "0x181680B30")]
		private CircuitSignal GetBooleanEquals(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x1680D90", Offset = "0x167F790", VA = "0x181680D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1695110", Offset = "0x1693B10", VA = "0x181695110")]
		public ToStringNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x1681240", Offset = "0x167FC40", VA = "0x181681240", Slot = "16")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x1694F60", Offset = "0x1693960", VA = "0x181694F60", Slot = "17")]
		protected override void OnTypesChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x1694B50", Offset = "0x1693550", VA = "0x181694B50")]
		private ConvertFunc GetDelegateForType(CircuitType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x1694DD0", Offset = "0x16937D0", VA = "0x181694DD0")]
		private CircuitSignal GetPlayerToString(CircuitContext context, CircuitSignal inputsignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x1694A80", Offset = "0x1693480", VA = "0x181694A80", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x1694EE0", Offset = "0x16938E0", VA = "0x181694EE0")]
		private static CircuitSignal GetReferenceToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x1694F40", Offset = "0x1693940", VA = "0x181694F40")]
		private static CircuitSignal GetStringToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x1694D10", Offset = "0x1693710", VA = "0x181694D10")]
		private static CircuitSignal GetFloatToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x1694D70", Offset = "0x1693770", VA = "0x181694D70")]
		private static CircuitSignal GetIntToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x1694AF0", Offset = "0x16934F0", VA = "0x181694AF0")]
		private static CircuitSignal GetBooleanToString(CircuitContext context, CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x1694CD0", Offset = "0x16936D0", VA = "0x181694CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1689E10", Offset = "0x1688810", VA = "0x181689E10")]
		public InvalidPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x1689DC0", Offset = "0x16887C0", VA = "0x181689DC0", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x94D5E0", Offset = "0x94BFE0", VA = "0x18094D5E0", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x168A1C0", Offset = "0x1688BC0", VA = "0x18168A1C0")]
		public LocalPlayerVariableNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x168A170", Offset = "0x1688B70", VA = "0x18168A170", Slot = "25")]
		protected override void Set(CircuitSignal value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x94D5E0", Offset = "0x94BFE0", VA = "0x18094D5E0", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x16864A0", Offset = "0x1684EA0", VA = "0x1816864A0")]
		public GetPlayerIsLocalNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x16863A0", Offset = "0x1684DA0", VA = "0x1816863A0", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x16866E0", Offset = "0x16850E0", VA = "0x1816866E0")]
		public GetPlayerNameNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x1686640", Offset = "0x1685040", VA = "0x181686640", Slot = "24")]
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
		[Cpp2IlInjected.Address(RVA = "0x16854B0", Offset = "0x1683EB0", VA = "0x1816854B0")]
		public GetAllPlayersNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x1685430", Offset = "0x1683E30", VA = "0x181685430")]
		private CircuitSignal GetPlayerList(IExecutionScope executionScope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x1685350", Offset = "0x1683D50", VA = "0x181685350", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AA0", Offset = "0x4124A0", VA = "0x180413AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E16F0", Offset = "0x3E00F0", VA = "0x1803E16F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4139D0", Offset = "0x4123D0", VA = "0x1804139D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E6920", Offset = "0x3E5320", VA = "0x1803E6920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x16917C0", Offset = "0x16901C0", VA = "0x1816917C0")]
		public PromptLocalPlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x1691540", Offset = "0x168FF40", VA = "0x181691540")]
		private CircuitSignal GetPromptResponse(IExecutionScope executionscope)
		{
			return default(CircuitSignal);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0x1691240", Offset = "0x168FC40", VA = "0x181691240", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x1691180", Offset = "0x168FB80", VA = "0x181691180")]
		private void ExecuteAfterPrompt(OutputPort fromPort)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FC")]
	[InternalNode]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x4EC70", Offset = "0x4E070")]
	[Guid("163C326E-6BB9-428A-8837-FF507D948E93")]
	public class GetPlayerHealthNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x1686200", Offset = "0x1684C00", VA = "0x181686200")]
		public GetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0x16860E0", Offset = "0x1684AE0", VA = "0x1816860E0", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FD")]
	[InternalNode]
	[Guid("6B962C79-6BE2-4E2C-A517-BE998B58F9D1")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x4EF20", Offset = "0x4E320")]
	public class GetPlayerShieldNode : TypeConversionNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private readonly IPlayerProvider playerProvider;

		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0x16869A0", Offset = "0x16853A0", VA = "0x1816869A0")]
		public GetPlayerShieldNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C12")]
		[Cpp2IlInjected.Address(RVA = "0x1686880", Offset = "0x1685280", VA = "0x181686880", Slot = "24")]
		protected override CircuitSignal Convert(CircuitSignal inputSignal)
		{
			return default(CircuitSignal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FE")]
	[InternalNode]
	[Guid("67ACA89C-F753-4F94-87DF-1CE1D4FCB8B0")]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x4F300", Offset = "0x4E700")]
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
			[Cpp2IlInjected.Address(RVA = "0x413A90", Offset = "0x412490", VA = "0x180413A90")]
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
			[Cpp2IlInjected.Address(RVA = "0x413AA0", Offset = "0x4124A0", VA = "0x180413AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x167F740", Offset = "0x167E140", VA = "0x18167F740")]
		public DamagePlayerNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x167F500", Offset = "0x167DF00", VA = "0x18167F500", Slot = "23")]
		protected override void ExecuteInternal(IExecutionScope executionScope)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001FF")]
	[InternalNode]
	[Cpp2IlInjected.Attribute(Name = "NodeTagAttribute", RVA = "0x4FA60", Offset = "0x4EE60")]
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
			[Cpp2IlInjected.Address(RVA = "0x413A90", Offset = "0x412490", VA = "0x180413A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x1692BE0", Offset = "0x16915E0", VA = "0x181692BE0")]
		public ResetPlayerHealthNode(CircuitContext circuitContext, Guid nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x1692A60", Offset = "0x1691460", VA = "0x181692A60", Slot = "23")]
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
			[Cpp2IlInjected.Address(RVA = "0x388BB0", Offset = "0x3875B0", VA = "0x180388BB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x391130", Offset = "0x38FB30", VA = "0x180391130", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x1230950", Offset = "0x122F350", VA = "0x181230950")]
		protected CircuitNetworking(IRPCSender rpcSender, IContextSynchronizedFieldFactory synchronizedFieldFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x18CCE40", Offset = "0x18CB840", VA = "0x1818CCE40", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x18C67F0", Offset = "0x18C51F0", VA = "0x1818C67F0")]
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
