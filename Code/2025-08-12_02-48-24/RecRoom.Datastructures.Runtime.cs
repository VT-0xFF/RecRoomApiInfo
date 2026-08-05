using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8420F70", Offset = "0x841F570", VA = "0x188420F70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DFBKFNIMIBA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23C4B80", Offset = "0x23C3180", VA = "0x1823C4B80")]
	public DFBKFNIMIBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, BAAPFHPILHC, ALMIKLLDPGJ, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash PDDACHIAKKM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD461A0", Offset = "0xD447A0", VA = "0x180D461A0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8423570", Offset = "0x8421B70", VA = "0x188423570")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8423530", Offset = "0x8421B30", VA = "0x188423530")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84235B0", Offset = "0x8421BB0", VA = "0x1884235B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8423760", Offset = "0x8421D60", VA = "0x188423760")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84236D0", Offset = "0x8421CD0", VA = "0x1884236D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAF2AF0", Offset = "0xAF10F0", VA = "0x180AF2AF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EB0", Offset = "0xAF14B0", VA = "0x180AF2EB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84234F0", Offset = "0x8421AF0", VA = "0x1884234F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8423640", Offset = "0x8421C40", VA = "0x188423640")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8422F90", Offset = "0x8421590", VA = "0x188422F90")]
	public void CopyBounds(SavedExtents IBCMCOKAJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8423440", Offset = "0x8421A40", VA = "0x188423440")]
	public void SetLocalSpaceBounds(Bounds EKKLPDHLPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x16F20F0", Offset = "0x16F06F0", VA = "0x1816F20F0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8423430", Offset = "0x8421A30", VA = "0x188423430")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8422FC0", Offset = "0x84215C0", VA = "0x188422FC0")]
	private void IAPANHMLNLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8423230", Offset = "0x8421830", VA = "0x188423230")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8422920", Offset = "0x8420F20", VA = "0x188422920")]
	public static void CalculateLocalBoundsFor(GameObject EGMHLHLEIMH, [Out] Bounds EKKLPDHLPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8423170", Offset = "0x8421770", VA = "0x188423170")]
	private static void JCPINEHMGGN(Bounds DFKKOPOBCBA, Color JNNOBIJIOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8423460", Offset = "0x8421A60", VA = "0x188423460")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1BBFBF0", Offset = "0x1BBE1F0", VA = "0x181BBFBF0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9C90", Offset = "0x5EB8290", VA = "0x185EB9C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public virtual void EDGJCFKPOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[DFBKFNIMIBA]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9870", Offset = "0x5EB7E70", VA = "0x185EB9870", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8560", Offset = "0x5EB6B60", VA = "0x185EB8560", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9BE0", Offset = "0x5EB81E0", VA = "0x185EB9BE0")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class HHJPDCDBPHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public HHJPDCDBPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50B77F0", Offset = "0x50B5DF0", VA = "0x1850B77F0")]
		internal int PHABPCNBBLP(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[DFBKFNIMIBA]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4AB3640", Offset = "0x4AB1C40", VA = "0x184AB3640", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4AB3690", Offset = "0x4AB1C90", VA = "0x184AB3690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4AB3540", Offset = "0x4AB1B40", VA = "0x184AB3540", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey HFLDIIIPBCG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4AB35E0", Offset = "0x4AB1BE0", VA = "0x184AB35E0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4AB3420", Offset = "0x4AB1A20", VA = "0x184AB3420", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4AB3130", Offset = "0x4AB1730", VA = "0x184AB3130", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2570", Offset = "0x4AB0B70", VA = "0x184AB2570", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2420", Offset = "0x4AB0A20", VA = "0x184AB2420", Slot = "14")]
	protected virtual string BJNNFJCAHJD(TKeyVal CCCCGIJJNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2480", Offset = "0x4AB0A80", VA = "0x184AB2480", Slot = "4")]
	public bool ContainsKey(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4AB32E0", Offset = "0x4AB18E0", VA = "0x184AB32E0", Slot = "5")]
	public bool TryGetValue(TKey HFLDIIIPBCG, [Out] TVal FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4AB24D0", Offset = "0x4AB0AD0", VA = "0x184AB24D0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4AB24D0", Offset = "0x4AB0AD0", VA = "0x184AB24D0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4AB3330", Offset = "0x4AB1930", VA = "0x184AB3330")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4A126E0", Offset = "0x4A10CE0", VA = "0x184A126E0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[DFBKFNIMIBA]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB470", Offset = "0x5EB9A70", VA = "0x185EBB470")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAD30", Offset = "0x5EB9330", VA = "0x185EBAD30", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA320", Offset = "0x5EB8920", VA = "0x185EBA320", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class JAJBCHEAGIA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct LCLMNJKGGLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T FAGODIAEODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float AEOOGMFJCHK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int EGJLNDPMOIJ = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float ONNKICKFACP = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly LCLMNJKGGLA[] OHHBFAGELLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int KBBDDJPNGOO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float KICIMMEIOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD847A0", Offset = "0xD82DA0", VA = "0x180D847A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDFA620", Offset = "0xDF8C20", VA = "0x180DFA620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T GPGPFJPAGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x549CCC0", Offset = "0x549B2C0", VA = "0x18549CCC0")]
	protected JAJBCHEAGIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x549CCE0", Offset = "0x549B2E0", VA = "0x18549CCE0")]
	protected JAJBCHEAGIA(int MLMBLBFOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x549CB20", Offset = "0x549B120", VA = "0x18549CB20")]
	public void KMLBEHGKDFG(float FLCAFPMKFLE, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool LNLCIFPJPBM(float AJOEJHMGHBJ, float FLAHAAINADJ, [Out] T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool LMBHHMIKGEB(float AJOEJHMGHBJ, float FLAHAAINADJ, [Out] T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x549CC60", Offset = "0x549B260", VA = "0x18549CC60")]
	public void OOIGDCNPPFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GBJJDEBLKGE : JAJBCHEAGIA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84205C0", Offset = "0x841EBC0", VA = "0x1884205C0", Slot = "4")]
	public override bool LNLCIFPJPBM(float AJOEJHMGHBJ, float FLAHAAINADJ, [Out] Vector3 FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8420480", Offset = "0x841EA80", VA = "0x188420480", Slot = "5")]
	public override bool LMBHHMIKGEB(float AJOEJHMGHBJ, float FLAHAAINADJ, [Out] Vector3 FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8420720", Offset = "0x841ED20", VA = "0x188420720")]
	public GBJJDEBLKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JBHLOGMMKIN
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3E2C210", Offset = "0x3E2A810", VA = "0x183E2C210")]
	public static KPACIKFJNGN<T1, T2> EEPJBIPIECL<T1, T2>(T1 EEOBLFAONCP, T2 FKNMCMLNMBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E2C290", Offset = "0x3E2A890", VA = "0x183E2C290")]
	public static CBJAIPMEKMO<T1, T2, T3> EEPJBIPIECL<T1, T2, T3>(T1 EEOBLFAONCP, T2 FKNMCMLNMBD, T3 DHIAIMAHEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x59B2680", Offset = "0x59B0C80", VA = "0x1859B2680")]
	internal static int MKGOFIKIAOD(int IECCACCBGOJ, int GMMCKGDKGOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75800B0", Offset = "0x757E6B0", VA = "0x1875800B0")]
	internal static int MKGOFIKIAOD(int IECCACCBGOJ, int GMMCKGDKGOL, int KGNKCHPILHE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KPACIKFJNGN<T1, T2> : IComparable<KPACIKFJNGN<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 OCLHAFKHFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 HAMNGAMNNAO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x560CAE0", Offset = "0x560B0E0", VA = "0x18560CAE0")]
	public KPACIKFJNGN(T1 EEOBLFAONCP, T2 FKNMCMLNMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x560ACD0", Offset = "0x56092D0", VA = "0x18560ACD0", Slot = "4")]
	public int CompareTo(KPACIKFJNGN<T1, T2> IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x560B3F0", Offset = "0x56099F0", VA = "0x18560B3F0", Slot = "0")]
	public override bool Equals(object IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x560C0A0", Offset = "0x560A6A0", VA = "0x18560C0A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x560C6E0", Offset = "0x560ACE0", VA = "0x18560C6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CBJAIPMEKMO<T1, T2, T3> : IComparable<CBJAIPMEKMO<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 OCLHAFKHFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 HAMNGAMNNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 MAFLKFBMDIF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6970", Offset = "0x6DC4F70", VA = "0x186DC6970")]
	public CBJAIPMEKMO(T1 EEOBLFAONCP, T2 FKNMCMLNMBD, T3 DHIAIMAHEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6140", Offset = "0x6DC4740", VA = "0x186DC6140", Slot = "4")]
	public int CompareTo(CBJAIPMEKMO<T1, T2, T3> IBCMCOKAJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC63A0", Offset = "0x6DC49A0", VA = "0x186DC63A0", Slot = "0")]
	public override bool Equals(object IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6600", Offset = "0x6DC4C00", VA = "0x186DC6600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DC67B0", Offset = "0x6DC4DB0", VA = "0x186DC67B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve CKFADLIMPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T PODKMNLBHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x14274A0", Offset = "0x1425AA0", VA = "0x1814274A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T CPPFMACHDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2F24A80", Offset = "0x2F23080", VA = "0x182F24A80")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2F24990", Offset = "0x2F22F90", VA = "0x182F24990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GDCIOCLCKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAE9950", Offset = "0xAE7F50", VA = "0x180AE9950")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61A0A40", Offset = "0x619F040", VA = "0x1861A0A40")]
	public T GHOCFAFNOPM(float IHNLGGEEIFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61A0E00", Offset = "0x619F400", VA = "0x1861A0E00")]
	public T PAIANFNKGOK(float IHNLGGEEIFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JPJNOCNJDNM(T KNPHEACNGDK, T IMDBLBCMEAE, float IHNLGGEEIFC);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8420400", Offset = "0x841EA00", VA = "0x188420400", Slot = "4")]
	protected override float JPJNOCNJDNM(float KNPHEACNGDK, float IMDBLBCMEAE, float IHNLGGEEIFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8420440", Offset = "0x841EA40", VA = "0x188420440")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1A071A0", Offset = "0x1A057A0", VA = "0x181A071A0", Slot = "4")]
	protected override Vector3 JPJNOCNJDNM(Vector3 KNPHEACNGDK, Vector3 IMDBLBCMEAE, float IHNLGGEEIFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84245B0", Offset = "0x8422BB0", VA = "0x1884245B0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8420270", Offset = "0x841E870", VA = "0x188420270", Slot = "4")]
	protected override Color JPJNOCNJDNM(Color KNPHEACNGDK, Color IMDBLBCMEAE, float IHNLGGEEIFC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8420330", Offset = "0x841E930", VA = "0x188420330")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IEINPGMHDBG : FHHAJIIIOLL<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8420AF0", Offset = "0x841F0F0", VA = "0x188420AF0")]
	public IEINPGMHDBG(int FAALOCBOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8420A80", Offset = "0x841F080", VA = "0x188420A80", Slot = "6")]
	protected override uint GFLBIEIFEBA(uint PDDACHIAKKM, string FKMNCAKIOFK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JFHGEONHHFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable DOBPPELCKJD;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JFHGEONHHFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FBNALMBPAPE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HFPHIGHBELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int CBMHMICPJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int JIOBLGBLOIO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4F23D90", Offset = "0x4F22390", VA = "0x184F23D90")]
	private FBNALMBPAPE(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OCKEMFKEINH, int DKIIDDCIEPB, int DPPAJNEFKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4F21AA0", Offset = "0x4F200A0", VA = "0x184F21AA0")]
	public static FBNALMBPAPE<T> BPFPEFLIIPC()
	{
		return default(FBNALMBPAPE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4F22290", Offset = "0x4F20890", VA = "0x184F22290")]
	public (int, int, Task<T>) MOFIAEGMADG(int KDNODDPEIGC, [Optional] CancellationToken MEKNAIONNND, double AEKHJIAHDFD = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4F21D40", Offset = "0x4F20340", VA = "0x184F21D40")]
	public void JOGLJDNIMCL(int KDNODDPEIGC, int DPPAJNEFKNP, [In] T CENCPMGPALN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CDMCIGMBFBH
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x84201A0", Offset = "0x841E7A0", VA = "0x1884201A0")]
	public static FBNALMBPAPE<GDCHOBJFCMN> BPFPEFLIIPC()
	{
		return default(FBNALMBPAPE<GDCHOBJFCMN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84201F0", Offset = "0x841E7F0", VA = "0x1884201F0")]
	public static void JOGLJDNIMCL([In] this FBNALMBPAPE<GDCHOBJFCMN> CCKLBDLJPNG, int KDNODDPEIGC, int DPPAJNEFKNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class PBOAKLMBFMM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> BCOOMGKOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> IGNFNGLGLNM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4568100", Offset = "0x4566700", VA = "0x184568100", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HBGKHJAILJC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> EKLAPLIICMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4FD4F40", Offset = "0x4FD3540", VA = "0x184FD4F40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> LNKJHKJCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5C57A90", Offset = "0x5C56090", VA = "0x185C57A90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5C57A30", Offset = "0x5C56030", VA = "0x185C57A30", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5C57AF0", Offset = "0x5C560F0", VA = "0x185C57AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5C571C0", Offset = "0x5C557C0", VA = "0x185C571C0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5C56A20", Offset = "0x5C55020", VA = "0x185C56A20", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5C57730", Offset = "0x5C55D30", VA = "0x185C57730", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5C56900", Offset = "0x5C54F00", VA = "0x185C56900", Slot = "9")]
	public void Add(TKey HFLDIIIPBCG, TVal FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5C569D0", Offset = "0x5C54FD0", VA = "0x185C569D0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5C56A80", Offset = "0x5C55080", VA = "0x185C56A80", Slot = "8")]
	public bool ContainsKey(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5C56BA0", Offset = "0x5C551A0", VA = "0x185C56BA0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5C576D0", Offset = "0x5C55CD0", VA = "0x185C576D0", Slot = "10")]
	public bool Remove(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5C57650", Offset = "0x5C55C50", VA = "0x185C57650", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5C57820", Offset = "0x5C55E20", VA = "0x185C57820", Slot = "11")]
	public bool TryGetValue(TKey HFLDIIIPBCG, [Out] TVal FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5C57070", Offset = "0x5C55670", VA = "0x185C57070", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5C56BD0", Offset = "0x5C551D0", VA = "0x185C56BD0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OHHBFAGELLA, int NCHALONGAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5C57600", Offset = "0x5C55C00", VA = "0x185C57600")]
	public bool NBJEBNMBDKD(TVal HFLDIIIPBCG, [Out] TKey FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5C56EF0", Offset = "0x5C554F0", VA = "0x185C56EF0")]
	private void FBPHDDOPEMI(TKey HFLDIIIPBCG, TVal PGNMBFKGLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5C56C50", Offset = "0x5C55250", VA = "0x185C56C50")]
	private void DLINFEMFOBF(TKey HFLDIIIPBCG, TVal PGNMBFKGLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5C573B0", Offset = "0x5C559B0", VA = "0x185C573B0")]
	private bool MJCICEELGAH(TKey HFLDIIIPBCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5C578C0", Offset = "0x5C55EC0", VA = "0x185C578C0")]
	public PBOAKLMBFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class EHNDEKCJBFL<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private EHNDEKCJBFL<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4B0AA70", Offset = "0x4B09070", VA = "0x184B0AA70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x4B24DE0", Offset = "0x4B233E0", VA = "0x184B24DE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4B26130", Offset = "0x4B24730", VA = "0x184B26130")]
		public Enumerator(EHNDEKCJBFL<T> COEFMBJKIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4B23740", Offset = "0x4B21D40", VA = "0x184B23740", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4B249C0", Offset = "0x4B22FC0", VA = "0x184B249C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4B24540", Offset = "0x4B22B40", VA = "0x184B24540")]
		private void NHJDOCJLNOD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] OJKALEKNNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int JNIDLJHCIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int FCPPDLMDEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int FOBPLBPGNLL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4A7EBA0", Offset = "0x4A7D1A0", VA = "0x184A7EBA0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4A7C5E0", Offset = "0x4A7ABE0", VA = "0x184A7C5E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4A7B850", Offset = "0x4A79E50", VA = "0x184A7B850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EB20", Offset = "0x4A7D120", VA = "0x184A7EB20")]
	public EHNDEKCJBFL(int FAALOCBOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DD50", Offset = "0x4A7C350", VA = "0x184A7DD50")]
	public void KMLBEHGKDFG(T IHNLGGEEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C790", Offset = "0x4A7AD90", VA = "0x184A7C790")]
	public void IGDPBMMMPEN(IEnumerable<T> KNPJHKKMLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E1B0", Offset = "0x4A7C7B0", VA = "0x184A7E1B0")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4A7DBD0", Offset = "0x4A7C1D0", VA = "0x184A7DBD0")]
	public void JPNLKFCMEOE(int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4A7BB10", Offset = "0x4A7A110", VA = "0x184A7BB10")]
	public void CBDEJAGDNOD(T[] OHHBFAGELLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C4A0", Offset = "0x4A7AAA0", VA = "0x184A7C4A0")]
	public Enumerator DKMCAGKLCHH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EA60", Offset = "0x4A7D060", VA = "0x184A7EA60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EA60", Offset = "0x4A7D060", VA = "0x184A7EA60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4A7E2E0", Offset = "0x4A7C8E0", VA = "0x184A7E2E0")]
	private int PBEHDDDKAMF(int LEPAEEGOBDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4A7BAE0", Offset = "0x4A7A0E0", VA = "0x184A7BAE0")]
	private int CAGGPCMLKMD(int LEPAEEGOBDO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PBBBJBDHKBF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> IIGAIBIPBPD(TRequest MLCIBEJGDFC, CancellationToken MEKNAIONNND);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum PLKILANOKCC
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NLNFNANIPGL
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float LMICMCIINLK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan FEPGGHLJBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int PNOACANDBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public PLKILANOKCC GOGDMLFDNEI;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly NLNFNANIPGL COLNIIHALMI;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float BJNNNGAACAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x59F89D0", Offset = "0x59F6FD0", VA = "0x1859F89D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan LKMMHNLPNAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x59F8C00", Offset = "0x59F7200", VA = "0x1859F8C00")]
		public NLNFNANIPGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct FFDODGAGFFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest MLCIBEJGDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken MEKNAIONNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> CBFLGCOACGP;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4F31910", Offset = "0x4F2FF10", VA = "0x184F31910")]
		public FFDODGAGFFF(TRequest MLCIBEJGDFC, TaskCompletionSource<TResult> CBFLGCOACGP, CancellationToken MEKNAIONNND)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct PFFLLHBNAFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public PBBBJBDHKBF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5C6A650", Offset = "0x5C68C50", VA = "0x185C6A650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5C6B250", Offset = "0x5C69850", VA = "0x185C6B250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct DLKDDFNDOEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PBBBJBDHKBF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private FFDODGAGFFF <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x45B7B50", Offset = "0x45B6150", VA = "0x1845B7B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x45B87E0", Offset = "0x45B6DE0", VA = "0x1845B87E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource NMLFCCMGGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<FFDODGAGFFF> ICHDADJJOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly NLNFNANIPGL OILIJICBOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IIGAIBIPBPD ADFOBPLHDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task DLAMBCLJFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int FFJKNNPAMNA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5C55CB0", Offset = "0x5C542B0", VA = "0x185C55CB0")]
	public PBBBJBDHKBF(IIGAIBIPBPD ADFOBPLHDGK, [Optional] NLNFNANIPGL OILIJICBOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5C55300", Offset = "0x5C53900", VA = "0x185C55300")]
	public Task<TResult> KMNHKEHNOND(TRequest MLCIBEJGDFC, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5C559F0", Offset = "0x5C53FF0", VA = "0x185C559F0")]
	private void LKDABJDLLPB(FFDODGAGFFF ECIKKBHEJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5C54750", Offset = "0x5C52D50", VA = "0x185C54750")]
	[AsyncStateMachine(typeof(PBBBJBDHKBF<, >.PFFLLHBNAFJ))]
	private Task ALNNPDEFDPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5C55070", Offset = "0x5C53670", VA = "0x185C55070")]
	private FFDODGAGFFF HAPKPHLDAEK()
	{
		return default(FFDODGAGFFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5C543C0", Offset = "0x5C529C0", VA = "0x185C543C0")]
	[AsyncStateMachine(typeof(PBBBJBDHKBF<, >.DLKDDFNDOEG))]
	private Task AIFIFHIHOHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5C54950", Offset = "0x5C52F50", VA = "0x185C54950")]
	private void FAJAOBFEJEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5C54820", Offset = "0x5C52E20", VA = "0x185C54820", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class ONGKPGBMIEA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> AHJLBOEGGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> AEPFHKIKGBC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4568100", Offset = "0x4566700", VA = "0x184568100", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HBGKHJAILJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T BNCJGLMKBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5675090", Offset = "0x5673690", VA = "0x185675090", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5B941D0", Offset = "0x5B927D0", VA = "0x185B941D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4F6A9F0", Offset = "0x4F68FF0", VA = "0x184F6A9F0", Slot = "11")]
	public void Add(T KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5B93A50", Offset = "0x5B92050", VA = "0x185B93A50")]
	public bool ILMKKBDBIHH(T KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5B93EC0", Offset = "0x5B924C0", VA = "0x185B93EC0", Slot = "15")]
	public bool Remove(T KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4FFA5B0", Offset = "0x4FF8BB0", VA = "0x184FFA5B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5000E70", Offset = "0x4FFF470", VA = "0x185000E70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5B938C0", Offset = "0x5B91EC0", VA = "0x185B938C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5B93920", Offset = "0x5B91F20", VA = "0x185B93920", Slot = "13")]
	public bool Contains(T KGKOGFAMIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5B93960", Offset = "0x5B91F60", VA = "0x185B93960", Slot = "14")]
	public void CopyTo(T[] OHHBFAGELLA, int NCHALONGAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x564F5D0", Offset = "0x564DBD0", VA = "0x18564F5D0", Slot = "6")]
	public int IndexOf(T KGKOGFAMIIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5B93B10", Offset = "0x5B92110", VA = "0x185B93B10", Slot = "7")]
	public void Insert(int LEPAEEGOBDO, T KGKOGFAMIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5B93CD0", Offset = "0x5B922D0", VA = "0x185B93CD0", Slot = "8")]
	public void RemoveAt(int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5B94000", Offset = "0x5B92600", VA = "0x185B94000")]
	public ONGKPGBMIEA()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2D96410", Offset = "0x2D94A10", VA = "0x182D96410")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8423B00", Offset = "0x8422100", VA = "0x188423B00")]
		public SerializedGuid([In] Guid CLPJLOJHBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8423850", Offset = "0x8421E50", VA = "0x188423850")]
		public static SerializedGuid ACGBGAOJHAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84239E0", Offset = "0x8421FE0", VA = "0x1884239E0")]
		public static SerializedGuid LMFMJGKBALF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84237F0", Offset = "0x8421DF0", VA = "0x1884237F0")]
		public bool ACEIOKDFPFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8423AD0", Offset = "0x84220D0", VA = "0x188423AD0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8423A50", Offset = "0x8422050", VA = "0x188423A50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8423900", Offset = "0x8421F00", VA = "0x188423900", Slot = "7")]
		public bool Equals(SerializedGuid IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8423940", Offset = "0x8421F40", VA = "0x188423940", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x84239D0", Offset = "0x8421FD0", VA = "0x1884239D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84238D0", Offset = "0x8421ED0", VA = "0x1884238D0", Slot = "6")]
		public int CompareTo(SerializedGuid IBCMCOKAJEM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HLAKJBOPKGB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type LFLOLDCPHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string AHLFMNHIHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool OJLINACMAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool DIMLOGMFFEM;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8420760", Offset = "0x841ED60", VA = "0x188420760")]
	public HLAKJBOPKGB(Type NLPALCGKPDN, string EKNPBBPOEMF, bool HGLFDMGGFBM = false, bool EGLGMKDGLCK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MEPAMPNPLPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int EDCLJKIDBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> KKFIEDICLPE(float FLCAFPMKFLE, [Optional] float? NLMJJDABJCM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BGFCIMPPOCA(float FLCAFPMKFLE, T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOIGDCNPPFG();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class BPDFHKHDOAL<T> : MEPAMPNPLPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class JLOFDGONDMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float ABINFPFCBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T FAGODIAEODP;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public JLOFDGONDMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GICGJPKNBBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GICGJPKNBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF250", Offset = "0x4FED850", VA = "0x184FEF250")]
		internal bool POPLDLODILC(JLOFDGONDMH sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float LKOINBPBFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float JAGJAPHGCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<JLOFDGONDMH> OLGJNFNONNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private LKFCFHEAHEC<JLOFDGONDMH> BNAFBJEODHB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EDCLJKIDBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6A26290", Offset = "0x6A24890", VA = "0x186A26290", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A263E0", Offset = "0x6A249E0", VA = "0x186A263E0")]
	public BPDFHKHDOAL(float EGCPFCLNCFO, float NKILDOKCNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6A257C0", Offset = "0x6A23DC0", VA = "0x186A257C0", Slot = "6")]
	public bool BGFCIMPPOCA(float FLCAFPMKFLE, T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A25F60", Offset = "0x6A24560", VA = "0x186A25F60", Slot = "5")]
	public IEnumerable<T> KKFIEDICLPE(float FLCAFPMKFLE, float? NLMJJDABJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A26370", Offset = "0x6A24970", VA = "0x186A26370", Slot = "7")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A25AD0", Offset = "0x6A240D0", VA = "0x186A25AD0")]
	private void IKDOKFKINBM(float FLCAFPMKFLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class MMPIAONPJAJ<T> : MEPAMPNPLPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct OICHANGBHNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T FAGODIAEODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float ABINFPFCBBN;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5685170", Offset = "0x5683770", VA = "0x185685170")]
		public OICHANGBHNM(T FKMNCAKIOFK, float FLCAFPMKFLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class DCKFIBCEMLM : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public MMPIAONPJAJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public DCKFIBCEMLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x459EDB0", Offset = "0x459D3B0", VA = "0x18459EDB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x459F290", Offset = "0x459D890", VA = "0x18459F290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x459F1A0", Offset = "0x459D7A0", VA = "0x18459F1A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x459F260", Offset = "0x459D860", VA = "0x18459F260", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float EGCPFCLNCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float NKILDOKCNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<OICHANGBHNM> OLGJNFNONNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int JNIDLJHCIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int IFBHEGPMDCB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int EDCLJKIDBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x597A980", Offset = "0x5978F80", VA = "0x18597A980")]
	public MMPIAONPJAJ(float EGCPFCLNCFO, float NKILDOKCNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5979DD0", Offset = "0x59783D0", VA = "0x185979DD0", Slot = "6")]
	public bool BGFCIMPPOCA(float FLCAFPMKFLE, T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x597A2A0", Offset = "0x59788A0", VA = "0x18597A2A0", Slot = "8")]
	public int BPLOMJHLMEH(float FLCAFPMKFLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x597A4E0", Offset = "0x5978AE0", VA = "0x18597A4E0", Slot = "5")]
	[IteratorStateMachine(typeof(MMPIAONPJAJ<>.DCKFIBCEMLM))]
	public IEnumerable<T> KKFIEDICLPE(float FLCAFPMKFLE, float? NLMJJDABJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x597A730", Offset = "0x5978D30", VA = "0x18597A730", Slot = "7")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x597A650", Offset = "0x5978C50", VA = "0x18597A650")]
	private void LGFFNKOHOJB(float FLCAFPMKFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x597A360", Offset = "0x5978960", VA = "0x18597A360")]
	private OICHANGBHNM ICIDAOKBABP()
	{
		return default(OICHANGBHNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EPDEFLOOMAM<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct OALCKAOIOKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long NHOINDJANCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long DEOPIOGNAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int GCJFNJIGMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int HPJDPOGMKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool NBMOKBJKEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string ICJIENOMAHN;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5B2DDF0", Offset = "0x5B2C3F0", VA = "0x185B2DDF0")]
		public OALCKAOIOKK(long NHOINDJANCF, int GCJFNJIGMIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5B2DDC0", Offset = "0x5B2C3C0", VA = "0x185B2DDC0")]
		public OALCKAOIOKK(long NHOINDJANCF, long DEOPIOGNAML, int GCJFNJIGMIP, int HPJDPOGMKKB, bool NBMOKBJKEOO, string ICJIENOMAHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5B2DC50", Offset = "0x5B2C250", VA = "0x185B2DC50")]
		public int ECINDAJJMCM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5B2DD40", Offset = "0x5B2C340", VA = "0x185B2DD40")]
		public int KLDLLPOPAPP(int KNALAIAADKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5B2DD60", Offset = "0x5B2C360", VA = "0x185B2DD60")]
		public double LFJFKDJPGAP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5B2DCA0", Offset = "0x5B2C2A0", VA = "0x185B2DCA0")]
		public OALCKAOIOKK IJJAPPCMIGJ(long DEOPIOGNAML, int HPJDPOGMKKB)
		{
			return default(OALCKAOIOKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class GONHOPCHFID : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct DPPMBOMCOEI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public GONHOPCHFID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<GONHOPCHFID, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private GONHOPCHFID <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x45D5B20", Offset = "0x45D4120", VA = "0x1845D5B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x45D6050", Offset = "0x45D4650", VA = "0x1845D6050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey PMMIAHCCEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly EPDEFLOOMAM<TKey> AGEIHALJKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly IDGHEFJHGEI FEFALLLFAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<GONHOPCHFID> GEKDBNAJPJI;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string HMHADGGEENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x501AF70", Offset = "0x5019570", VA = "0x18501AF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<GONHOPCHFID> CKHLPOACJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x501AF00", Offset = "0x5019500", VA = "0x18501AF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public OALCKAOIOKK NFLNBLDJFHN
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x501AEE0", Offset = "0x50194E0", VA = "0x18501AEE0")]
			[CompilerGenerated]
			get
			{
				return default(OALCKAOIOKK);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x501AF40", Offset = "0x5019540", VA = "0x18501AF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x501AFA0", Offset = "0x50195A0", VA = "0x18501AFA0")]
		internal GONHOPCHFID(EPDEFLOOMAM<TKey> AGEIHALJKLD, TKey HFLDIIIPBCG, IDGHEFJHGEI FEFALLLFAGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x501AB80", Offset = "0x5019180", VA = "0x18501AB80")]
		public GONHOPCHFID CDBFKPGDHKK(TKey HFLDIIIPBCG, [Optional] IDGHEFJHGEI? JPAMKAJKEFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x44634C0", Offset = "0x4461AC0", VA = "0x1844634C0")]
		[AsyncStateMachine(typeof(DPPMBOMCOEI<>))]
		public Task<T> GMMBEMDGMLK<T>(TKey HFLDIIIPBCG, Func<GONHOPCHFID, Task<T>> MGENEOADHDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x501ACE0", Offset = "0x50192E0", VA = "0x18501ACE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class FBBGOLKOENF : IEnumerable<(TKey, List<TKey>, OALCKAOIOKK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OALCKAOIOKK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, OALCKAOIOKK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EPDEFLOOMAM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, OALCKAOIOKK timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, OALCKAOIOKK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2D85440", Offset = "0x2D83A40", VA = "0x182D85440", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OALCKAOIOKK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x4F1F8B0", Offset = "0x4F1DEB0", VA = "0x184F1F8B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2D85530", Offset = "0x2D83B30", VA = "0x182D85530")]
		[DebuggerHidden]
		public FBBGOLKOENF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4F1F910", Offset = "0x4F1DF10", VA = "0x184F1F910", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4F1F3B0", Offset = "0x4F1D9B0", VA = "0x184F1F3B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4F1F750", Offset = "0x4F1DD50", VA = "0x184F1F750")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4F1F860", Offset = "0x4F1DE60", VA = "0x184F1F860", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4F1F7A0", Offset = "0x4F1DDA0", VA = "0x184F1F7A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OALCKAOIOKK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x45C4100", Offset = "0x45C2700", VA = "0x1845C4100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class JJJNFBBCNAP : IEnumerable<(TKey, List<TKey>, OALCKAOIOKK)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OALCKAOIOKK)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, OALCKAOIOKK timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private GONHOPCHFID timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public GONHOPCHFID <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EPDEFLOOMAM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<GONHOPCHFID> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, OALCKAOIOKK timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, OALCKAOIOKK) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2D85440", Offset = "0x2D83A40", VA = "0x182D85440", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OALCKAOIOKK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x54C4700", Offset = "0x54C2D00", VA = "0x1854C4700", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2D85530", Offset = "0x2D83B30", VA = "0x182D85530")]
		[DebuggerHidden]
		public JJJNFBBCNAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x54C4760", Offset = "0x54C2D60", VA = "0x1854C4760", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x54C3DA0", Offset = "0x54C23A0", VA = "0x1854C3DA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x54C4540", Offset = "0x54C2B40", VA = "0x1854C4540")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x54C3D40", Offset = "0x54C2340", VA = "0x1854C3D40")]
		private void LGNDDFAIONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x54C46B0", Offset = "0x54C2CB0", VA = "0x1854C46B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x54C45A0", Offset = "0x54C2BA0", VA = "0x1854C45A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OALCKAOIOKK)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x54C4680", Offset = "0x54C2C80", VA = "0x1854C4680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, OALCKAOIOKK, IDGHEFJHGEI> LKHCPNCANPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, OALCKAOIOKK, IDGHEFJHGEI> FAHKINEDBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<EPDEFLOOMAM<TKey>, IDGHEFJHGEI> EEEGBMDBHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly GONHOPCHFID JLHKOCKPOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool JBOBNJDEDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int KDPFENNHIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch LONLIFGFCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int EBDDKCFCMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string AJCIAGECCHI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GONHOPCHFID OEBOJHCAJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string HMHADGGEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4AA6630", Offset = "0x4AA4C30", VA = "0x184AA6630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6690", Offset = "0x4AA4C90", VA = "0x184AA6690")]
	public EPDEFLOOMAM(TKey BIDBECIENEB, IDGHEFJHGEI FEFALLLFAGB, [Optional] int? GCJFNJIGMIP, [Optional][CanBeNull] Stopwatch LONLIFGFCLO, [Optional] Action<TKey, OALCKAOIOKK, IDGHEFJHGEI> LKHCPNCANPM, [Optional] Action<TKey, OALCKAOIOKK, IDGHEFJHGEI> FAHKINEDBNC, [Optional] Action<EPDEFLOOMAM<TKey>, IDGHEFJHGEI> EEEGBMDBHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4AA63C0", Offset = "0x4AA49C0", VA = "0x184AA63C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6520", Offset = "0x4AA4B20", VA = "0x184AA6520")]
	[IteratorStateMachine(typeof(EPDEFLOOMAM<>.FBBGOLKOENF))]
	public IEnumerable<(TKey, List<TKey>, OALCKAOIOKK)> FNLOCCKMNHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4AA6450", Offset = "0x4AA4A50", VA = "0x184AA6450")]
	[IteratorStateMachine(typeof(EPDEFLOOMAM<>.JJJNFBBCNAP))]
	private IEnumerable<(TKey, List<TKey>, OALCKAOIOKK)> FNLOCCKMNHK(List<TKey> JKCPEHCGLIK, GONHOPCHFID CBBBAPDFDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4AA65B0", Offset = "0x4AA4BB0", VA = "0x184AA65B0")]
	private (long, int) HEBBLLBAPIE()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class BMHMJPALNNJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut AIJCJONLLDB(EPDEFLOOMAM<TKey> AGEIHALJKLD);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected BMHMJPALNNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class CNJIDJKOAJP<TKey> : BMHMJPALNNJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string KNKLJPNGMGK(TKey HFLDIIIPBCG);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6EC82D0", Offset = "0x6EC68D0", VA = "0x186EC82D0")]
	private static string LAAGECNMGCD(TKey HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6EC80C0", Offset = "0x6EC66C0", VA = "0x186EC80C0", Slot = "4")]
	public override string AIJCJONLLDB(EPDEFLOOMAM<TKey> AGEIHALJKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8180", Offset = "0x6EC6780", VA = "0x186EC8180")]
	public string AIJCJONLLDB(EPDEFLOOMAM<TKey> AGEIHALJKLD, [NotNull] KNKLJPNGMGK FMCJLOOBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EIGCINHFFAC(EPDEFLOOMAM<TKey> AGEIHALJKLD, [NotNull] KNKLJPNGMGK FMCJLOOBEFP);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x52768C0", Offset = "0x5274EC0", VA = "0x1852768C0")]
	protected CNJIDJKOAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NNPJMPBNLLA<TKey> : BMHMJPALNNJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string CLKCPDBIBIO(TKey HFLDIIIPBCG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string EKKDBIICMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double HNLPPDDILHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool LPEPFKBEMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int EJNJHDNBLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> BLEMGNAAEFK;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5A04600", Offset = "0x5A02C00", VA = "0x185A04600")]
	private static string LAAGECNMGCD(TKey HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5A04640", Offset = "0x5A02C40", VA = "0x185A04640")]
	public NNPJMPBNLLA(string EKKDBIICMGG = "F2", double HNLPPDDILHN = double.MaxValue, bool LPEPFKBEMEM = false, int EJNJHDNBLOH = int.MaxValue, [Optional] ISet<string> BLEMGNAAEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5A03AE0", Offset = "0x5A020E0", VA = "0x185A03AE0", Slot = "4")]
	public override Dictionary<string, string> AIJCJONLLDB(EPDEFLOOMAM<TKey> AGEIHALJKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5A04190", Offset = "0x5A02790", VA = "0x185A04190")]
	private bool GMEFCNNLGBG(string MNDFFMCPPIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5A03BA0", Offset = "0x5A021A0", VA = "0x185A03BA0")]
	public Dictionary<string, string> AIJCJONLLDB(EPDEFLOOMAM<TKey> AGEIHALJKLD, CLKCPDBIBIO FMCJLOOBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5A043C0", Offset = "0x5A029C0", VA = "0x185A043C0")]
	private string KEHGHMFHKOP(StringBuilder FJOAMKOHPGK, List<TKey> BFALPAIHBLJ, CLKCPDBIBIO FMCJLOOBEFP, bool MJDOKBMEIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5A04260", Offset = "0x5A02860", VA = "0x185A04260")]
	private static void HPNDHPMDLPL(StringBuilder MJBCOGHAAGF, string FAGPMEDLGMF, bool JPAEDMFMNKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class CDNIAEPAKPG<TKey> : CNJIDJKOAJP<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BFFHKEIMFFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public KNKLJPNGMGK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static CDNIAEPAKPG<TKey> DOBPPELCKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] KDKBJGJGHKK;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCAC0", Offset = "0x6DCB0C0", VA = "0x186DCCAC0")]
	private CDNIAEPAKPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBA40", Offset = "0x6DCA040", VA = "0x186DCBA40", Slot = "5")]
	protected override string EIGCINHFFAC(EPDEFLOOMAM<TKey> AGEIHALJKLD, KNKLJPNGMGK FMCJLOOBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC890", Offset = "0x6DCAE90", VA = "0x186DCC890")]
	[CompilerGenerated]
	internal static string LNLBOBHFIEA(string PMDMBIDPNLF, TKey HFLDIIIPBCG, BFFHKEIMFFO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class AEBLLICOIOB : EPDEFLOOMAM<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class EFNHHBOAKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<AEBLLICOIOB, IDGHEFJHGEI> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EFNHHBOAKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8420370", Offset = "0x841E970", VA = "0x188420370")]
		internal void IDNBNICIIAK(EPDEFLOOMAM<string> timer, IDGHEFJHGEI log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x841F640", Offset = "0x841DC40", VA = "0x18841F640")]
	public AEBLLICOIOB(IDGHEFJHGEI FEFALLLFAGB, [Optional] string CAFMONOLGHE, [Optional] int? GCJFNJIGMIP, [Optional] Stopwatch LONLIFGFCLO, [Optional] Action<string, OALCKAOIOKK, IDGHEFJHGEI> LKHCPNCANPM, [Optional] Action<string, OALCKAOIOKK, IDGHEFJHGEI> FAHKINEDBNC, [Optional] Action<AEBLLICOIOB, IDGHEFJHGEI> EEEGBMDBHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x841F580", Offset = "0x841DB80", VA = "0x18841F580")]
	private static Action<EPDEFLOOMAM<string>, IDGHEFJHGEI> DFNHHAMNJFG(Action<AEBLLICOIOB, IDGHEFJHGEI> GDMDDGECOJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class JNMOGINHHOP
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class ONHDFFDBNOG : JNMOGINHHOP
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static JNMOGINHHOP DOBPPELCKJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8420FF0", Offset = "0x841F5F0", VA = "0x188420FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float BGHDNEKOEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x13BEB50", Offset = "0x13BD150", VA = "0x1813BEB50", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x84210F0", Offset = "0x841F6F0", VA = "0x1884210F0")]
		public ONHDFFDBNOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static JNMOGINHHOP JMHDELGHJBA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static JNMOGINHHOP COLNIIHALMI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8420BC0", Offset = "0x841F1C0", VA = "0x188420BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float BGHDNEKOEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected JNMOGINHHOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface LOOEBIAEJGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool AFNNFFJLAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LHNBHFNPODB<T> : LOOEBIAEJGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> EMMJGHBCNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	LDNIFFJFEMD<T> DFLDAFODNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class NLNBAPDIGKE
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3F19F40", Offset = "0x3F18540", VA = "0x183F19F40")]
	public static LHNBHFNPODB<TResource> IKCJBLOBMLB<TResource, TId>(this HPFPKBEMHCF<TId, TResource> GMBMBGKOJIH, TId JIEJOKBHEMF, [Optional] Func<TId, CancellationToken, Task<TResource>>? MJIIEMOLGEL) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class IKOIHMNICAE
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class HHANKGGEEEH<T> : LAMDOEDKCLP<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> EMMJGHBCNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override LDNIFFJFEMD<T?> DFLDAFODNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x50B64A0", Offset = "0x50B4AA0", VA = "0x1850B64A0")]
		public HHANKGGEEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "10")]
		protected override void ANMFKAPINNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class DFHLANNNNOM<T> : LAMDOEDKCLP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T GIHMNJCEAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? DKNCBDCOAED;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> EMMJGHBCNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override LDNIFFJFEMD<T> DFLDAFODNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x45A2D40", Offset = "0x45A1340", VA = "0x1845A2D40")]
		public DFHLANNNNOM(T JLOKLPELFOB, Action<T>? CANPFBOHDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x45A2CC0", Offset = "0x45A12C0", VA = "0x1845A2CC0", Slot = "10")]
		protected override void ANMFKAPINNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class PNPEJPEHMJP<T> : LAMDOEDKCLP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> EMMJGHBCNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override LDNIFFJFEMD<T> DFLDAFODNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5C9A320", Offset = "0x5C98920", VA = "0x185C9A320")]
		public PNPEJPEHMJP(Exception ANEOEAMDEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "10")]
		protected override void ANMFKAPINNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class AOIOHLEIOBA<T> : LAMDOEDKCLP<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct NANDEDHMCKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<LHNBHFNPODB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<LHNBHFNPODB<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x59C5120", Offset = "0x59C3720", VA = "0x1859C5120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x59C5630", Offset = "0x59C3C30", VA = "0x1859C5630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct JCHBFLMKMOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<LHNBHFNPODB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<LHNBHFNPODB<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x549FDE0", Offset = "0x549E3E0", VA = "0x18549FDE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x54A0240", Offset = "0x549E840", VA = "0x1854A0240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<LHNBHFNPODB<T>> HBNHEJPAPCN;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> EMMJGHBCNNA
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override LDNIFFJFEMD<T> DFLDAFODNDE
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x56744D0", Offset = "0x5672AD0", VA = "0x1856744D0")]
		public AOIOHLEIOBA(Task<LHNBHFNPODB<T>> PIKAFIDPPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5673FA0", Offset = "0x56725A0", VA = "0x185673FA0", Slot = "10")]
		protected override void ANMFKAPINNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5674370", Offset = "0x5672970", VA = "0x185674370")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(AOIOHLEIOBA<>.NANDEDHMCKH))]
		internal static Task<T> OHOAFLPDLJA(Task<LHNBHFNPODB<T>> PIKAFIDPPMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5674030", Offset = "0x5672630", VA = "0x185674030")]
		[AsyncStateMachine(typeof(AOIOHLEIOBA<>.JCHBFLMKMOO))]
		[CompilerGenerated]
		internal static Task HAGPJNLIKPP(Task<LHNBHFNPODB<T>> PIKAFIDPPMC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class CKLDEOEDOAP<TIn, TOut> : LAMDOEDKCLP<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct LDMGDLKCEDC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x56D3F00", Offset = "0x56D2500", VA = "0x1856D3F00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x45A5B10", Offset = "0x45A4110", VA = "0x1845A5B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly LHNBHFNPODB<TIn> EEJAKEKLFMP;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> EMMJGHBCNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override LDNIFFJFEMD<TOut> DFLDAFODNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6EC3660", Offset = "0x6EC1C60", VA = "0x186EC3660")]
		public CKLDEOEDOAP(LHNBHFNPODB<TIn> FCGAMCLLKLA, Func<TIn, TOut> DHIKLCCINDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6EC3310", Offset = "0x6EC1910", VA = "0x186EC3310", Slot = "10")]
		protected override void ANMFKAPINNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6EC3360", Offset = "0x6EC1960", VA = "0x186EC3360")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(CKLDEOEDOAP<, >.LDMGDLKCEDC))]
		internal static Task<TOut> MIJLKBKHEFD(Task<TIn> BPANFOMMCFF, Func<TIn, TOut> DHIKLCCINDL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3E150F0", Offset = "0x3E136F0", VA = "0x183E150F0")]
	public static LHNBHFNPODB<T> KBCDDOOGPEK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3E15060", Offset = "0x3E13660", VA = "0x183E15060")]
	public static LHNBHFNPODB<T> HIKEOHLDJKB<T>(T CENCPMGPALN, [Optional] Action<T>? CANPFBOHDNC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8630", Offset = "0x3BD6C30", VA = "0x183BD8630")]
	public static LHNBHFNPODB<T> DKDDOHHLPLG<T>(Exception ANEOEAMDEHB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8630", Offset = "0x3BD6C30", VA = "0x183BD8630")]
	public static LHNBHFNPODB<T> LMCECPHPFOO<T>(Task<LHNBHFNPODB<T>> PIKAFIDPPMC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A180", Offset = "0x3B88780", VA = "0x183B8A180")]
	public static LHNBHFNPODB<TOut> ADNKINOHCOK<TOut, TIn>(LHNBHFNPODB<TIn> IINGFCBPPPE, Func<TIn, TOut> DHIKLCCINDL) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class LAMDOEDKCLP<T> : LHNBHFNPODB<T>, LOOEBIAEJGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string GLOIGPCLJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly EDAJBCAFGNC LDDFMHPFJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool JBOBNJDEDEL;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool AFNNFFJLAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB72670", Offset = "0xB70C70", VA = "0x180B72670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> EMMJGHBCNNA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract LDNIFFJFEMD<T> DFLDAFODNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5687FE0", Offset = "0x56865E0", VA = "0x185687FE0")]
	public LAMDOEDKCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5687CA0", Offset = "0x56862A0", VA = "0x185687CA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void ANMFKAPINNG();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class IOCOKHAGBCG<TTask, T> : LAMDOEDKCLP<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class BOEEDDHOFLM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public BOEEDDHOFLM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x454FAB0", Offset = "0x454E0B0", VA = "0x18454FAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4550020", Offset = "0x454E620", VA = "0x184550020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public IOCOKHAGBCG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BOEEDDHOFLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6A227F0", Offset = "0x6A20DF0", VA = "0x186A227F0")]
		[AsyncStateMachine(typeof(IOCOKHAGBCG<, >.BOEEDDHOFLM.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> LBEPDJFHALC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> PIKAFIDPPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource HJMKFNDDHID;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> EMMJGHBCNNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override LDNIFFJFEMD<T> DFLDAFODNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x52774E0", Offset = "0x5275AE0", VA = "0x1852774E0")]
	protected IOCOKHAGBCG(TTask PIKAFIDPPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5277490", Offset = "0x5275A90", VA = "0x185277490", Slot = "10")]
	protected override void ANMFKAPINNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T ECBJIHEMCDG(TTask PNHNJDDLKFA);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void OHCKCEIJJDL();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HGPKCKECODI<T> : LAMDOEDKCLP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly CJGHGFLGCGA<Task<T>> NCDLGDOPMEM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> EMMJGHBCNNA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4F303C0", Offset = "0x4F2E9C0", VA = "0x184F303C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override LDNIFFJFEMD<T> DFLDAFODNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x50B63B0", Offset = "0x50B49B0", VA = "0x1850B63B0")]
	public HGPKCKECODI(CJGHGFLGCGA<Task<T>> HFNKKLKGOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x50B6390", Offset = "0x50B4990", VA = "0x1850B6390", Slot = "10")]
	protected override void ANMFKAPINNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BDEDMNEAIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName JEFGIMPNJOO;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> NFJKOEAPAHL;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x841F910", Offset = "0x841DF10", VA = "0x18841F910")]
	public static int INENNBPNHIN(this BAAPFHPILHC BJHNMLNIMOF, IncrementalHash PDDACHIAKKM, byte[] GAIJOIPCFDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x841FFF0", Offset = "0x841E5F0", VA = "0x18841FFF0")]
	public static bool OAJLECLPDDE([CanBeNull] this BAAPFHPILHC BJHNMLNIMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x841F9A0", Offset = "0x841DFA0", VA = "0x18841F9A0")]
	public static bool OAJLECLPDDE([CanBeNull] this BAAPFHPILHC BJHNMLNIMOF, [Out] string GJJJIJGCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x841FCB0", Offset = "0x841E2B0", VA = "0x18841FCB0")]
	public static bool OAJLECLPDDE([CanBeNull] this BAAPFHPILHC BJHNMLNIMOF, IncrementalHash PDDACHIAKKM, byte[] GAIJOIPCFDM, [Out] string GJJJIJGCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x841F880", Offset = "0x841DE80", VA = "0x18841F880")]
	private static bool DHNLMNANOCC(byte[] CNIPJOCOBHM, Span<byte> ACNHIAPKHBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MINPJALLAEA
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8420D30", Offset = "0x841F330", VA = "0x188420D30")]
	public static int HIFFAMLLLGA(HashAlgorithmName PAPBPBBNFIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3EAC1D0", Offset = "0x3EAA7D0", VA = "0x183EAC1D0")]
	public static int INENNBPNHIN<T>(this T LFDFJPFMEFA, byte[] IELADMOKGEH, IncrementalHash PDDACHIAKKM, byte[] LBOHHACNNBB) where T : ALMIKLLDPGJ
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface ALMIKLLDPGJ
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash PDDACHIAKKM);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BAAPFHPILHC : ALMIKLLDPGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] IBFHBMOEIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] PJNNKKOMDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class PBNHDKOENOE
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool HNOAKPENDAC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> HMOHHDJMNFM;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> FAIAFLOIEGB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding JHCMMMDCEMP;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> HKNMAGCPFOE;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3F68030", Offset = "0x3F66630", VA = "0x183F68030")]
	public static void OBCLIKENNOB<T>(this IncrementalHash BHDBKMHPJIB, [CanBeNull] T OFJDOOOKCLI) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3F66E20", Offset = "0x3F65420", VA = "0x183F66E20")]
	public static void CKNAPOBGBPA<T>(this IncrementalHash BHDBKMHPJIB, [CanBeNull] T LFDFJPFMEFA) where T : ALMIKLLDPGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3F67B10", Offset = "0x3F66110", VA = "0x183F67B10")]
	public static void MAEJCIJEKNK<T>(this IncrementalHash BHDBKMHPJIB, [CanBeNull] IList<T> KGGHCMNJALP) where T : ALMIKLLDPGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8421550", Offset = "0x841FB50", VA = "0x188421550")]
	private static bool CKBMMMEDPBO([CanBeNull] ALMIKLLDPGJ LFDFJPFMEFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8421140", Offset = "0x841F740", VA = "0x188421140")]
	public static void BOHJFFNOAKD(this IncrementalHash PDDACHIAKKM, string? EGBCENAKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8421EB0", Offset = "0x84204B0", VA = "0x188421EB0")]
	public static void OJGDFIFPOMP(this IncrementalHash PDDACHIAKKM, long PKFOKCGFHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x84215E0", Offset = "0x841FBE0", VA = "0x1884215E0")]
	public static void EOIKBPGDFHM(this IncrementalHash PDDACHIAKKM, int GDPPEJDAEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8421AF0", Offset = "0x84200F0", VA = "0x188421AF0")]
	public static void KAAJBANNLBO(this IncrementalHash PDDACHIAKKM, short OFFINGEFIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x84217B0", Offset = "0x841FDB0", VA = "0x1884217B0")]
	public static void HAIIACCOGIB(this IncrementalHash PDDACHIAKKM, byte DHHCOMKMIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x84218C0", Offset = "0x841FEC0", VA = "0x1884218C0")]
	public static void IJLINBCFFCI(this IncrementalHash PDDACHIAKKM, bool NNLFFPBIBFD, bool NPMIEFKCDGA = false, bool NLANMDHGIHJ = false, bool AFMGNKMCAKH = false, bool NENLPEPNIJJ = false, bool OGKDBLIDACE = false, bool DOCDDKGJPGC = false, bool KJPCBHOPAGM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3F66EB0", Offset = "0x3F654B0", VA = "0x183F66EB0")]
	public static void IDFNPIPEGBA<T>(this IncrementalHash PDDACHIAKKM, T FBLLKKIPJDD) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8421A90", Offset = "0x8420090", VA = "0x188421A90")]
	public static void JOJGEIOEKED(this IncrementalHash PDDACHIAKKM, float PKJGGLCEAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8421D20", Offset = "0x8420320", VA = "0x188421D20")]
	public static void LIDJKFHNKIE(this IncrementalHash PDDACHIAKKM, ulong CEAPMHLAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8421CC0", Offset = "0x84202C0", VA = "0x188421CC0")]
	public static void KJKKHGFDPIP(this IncrementalHash PDDACHIAKKM, uint CHLCLONCPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8421A30", Offset = "0x8420030", VA = "0x188421A30")]
	public static void JFOJALAEBDN(this IncrementalHash PDDACHIAKKM, ushort AGLAICJFNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8421D80", Offset = "0x8420380", VA = "0x188421D80")]
	public static void NCJDDMCBCJL(this IncrementalHash PDDACHIAKKM, Vector3 OOPHDDMJKPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class IBLGMOONNAG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x84207D0", Offset = "0x841EDD0", VA = "0x1884207D0")]
	public IBLGMOONNAG(string IFEHDCDCFPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class NNLEIFNCEHM
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void NMMCGJPHDJD(ushort HLLIKLCKLPI, ushort OHLJEMCHIII, ushort JACKKLKNEKP, ushort DJBCBMFHLMI);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void ALNNBPPKCPJ(ushort EHPMGMNAGJK, ushort CHCOFCJDDMK);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void ENLKLACPBON();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort DKPJLILHCLC = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	protected NNLEIFNCEHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class KBFAIGEJCBO<T> : NNLEIFNCEHM where T : KBFAIGEJCBO<T>.BDOENFKODGD
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface BDOENFKODGD
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		ALNNBPPKCPJ MHHNOPDFJGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		ALNNBPPKCPJ EFIKMKJBHCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		ENLKLACPBON NCNALAJHCAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> PAHAPJPIEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private ENLKLACPBON IPIOFJBAMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private ENLKLACPBON LKFMAFIGODC;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool GNFELKMLABK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xAA0590", Offset = "0xA9EB90", VA = "0x180AA0590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort JHPLCMLFLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x127CA00", Offset = "0x127B000", VA = "0x18127CA00")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x127C840", Offset = "0x127AE40", VA = "0x18127C840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort BIGEKIBHPKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x55A9DD0", Offset = "0x55A83D0", VA = "0x1855A9DD0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x55A9C80", Offset = "0x55A8280", VA = "0x1855A9C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort EFGAIKEKGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xF5B240", Offset = "0xF59840", VA = "0x180F5B240")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xF5B300", Offset = "0xF59900", VA = "0x180F5B300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort IFJDIIHBNEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x55A9DE0", Offset = "0x55A83E0", VA = "0x1855A9DE0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x55AA170", Offset = "0x55A8770", VA = "0x1855AA170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool NLBDPBPEEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x127C830", Offset = "0x127AE30", VA = "0x18127C830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool AEPBOLPJFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x22F7A70", Offset = "0x22F6070", VA = "0x1822F7A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NMMCGJPHDJD BLNIFENMDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x55A92B0", Offset = "0x55A78B0", VA = "0x1855A92B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x55AA0D0", Offset = "0x55A86D0", VA = "0x1855AA0D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x55AA040", Offset = "0x55A8640", VA = "0x1855AA040")]
	private T KJJBFANKKMO(ushort KIBMHJJOLCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x55A9360", Offset = "0x55A7960", VA = "0x1855A9360")]
	private T DKFBGKDFFLH(ushort KIBMHJJOLCB, ushort IFOOGNKICJP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x55A9470", Offset = "0x55A7A70", VA = "0x1855A9470")]
	protected T GMNNNGMKEPH(uint HOBCHNGMHPI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x55AA180", Offset = "0x55A8780", VA = "0x1855AA180")]
	protected KBFAIGEJCBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x55A9C90", Offset = "0x55A8290", VA = "0x1855A9C90")]
	public void JEAALLEDIFA(ushort AMEGIKPDIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x55A9D80", Offset = "0x55A8380", VA = "0x1855A9D80")]
	public void JEAALLEDIFA(ushort AMEGIKPDIFD, ushort EFOMDIIGEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x55A9CB0", Offset = "0x55A82B0", VA = "0x1855A9CB0", Slot = "4")]
	protected virtual void JEAALLEDIFA(uint ACBFMIBGADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x55A94C0", Offset = "0x55A7AC0", VA = "0x1855A94C0")]
	protected void HHEFPGOANHK(uint ACBFMIBGADC, uint HAENMICICGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x55A93F0", Offset = "0x55A79F0", VA = "0x1855A93F0")]
	protected void FJPJBPLEBEJ(ushort KIBMHJJOLCB, ushort IFOOGNKICJP, T BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x55A9C50", Offset = "0x55A8250", VA = "0x1855A9C50")]
	private void IJBIJOPEHOL(uint HOBCHNGMHPI, T BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x55A9DF0", Offset = "0x55A83F0", VA = "0x1855A9DF0")]
	protected void KHFFJPNGJKE(float KNMJNADDDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x55A9C40", Offset = "0x55A8240", VA = "0x1855A9C40")]
	protected uint IFJECIOBPFD(ushort KIBMHJJOLCB, ushort IFOOGNKICJP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x55A9350", Offset = "0x55A7950", VA = "0x1855A9350")]
	protected ushort BIGHGBCKFAI(uint JDJOOMNCOGK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x55A9460", Offset = "0x55A7A60", VA = "0x1855A9460")]
	protected ushort FMNNBHJMOEC(uint JDJOOMNCOGK)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class IDAJLBKGAIN : KBFAIGEJCBO<IDAJLBKGAIN.ADLGFLHOKGC>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class ADLGFLHOKGC : BDOENFKODGD
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public ALNNBPPKCPJ MHHNOPDFJGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public ALNNBPPKCPJ EFIKMKJBHCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public ENLKLACPBON NCNALAJHCAA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ADLGFLHOKGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8420960", Offset = "0x841EF60", VA = "0x188420960")]
	public void LCDKDMIHKDK(ushort IHBIGCDINIE, ALNNBPPKCPJ PADBGDELDAC, ALNNBPPKCPJ KBBLMPGLLIF, ENLKLACPBON EGLJDOHIFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8420880", Offset = "0x841EE80", VA = "0x188420880")]
	public void LCDKDMIHKDK(ushort KIBMHJJOLCB, ushort IFOOGNKICJP, ALNNBPPKCPJ PADBGDELDAC, ALNNBPPKCPJ KBBLMPGLLIF, ENLKLACPBON EGLJDOHIFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8420830", Offset = "0x841EE30", VA = "0x188420830")]
	public void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x8420A40", Offset = "0x841F040", VA = "0x188420A40")]
	protected IDAJLBKGAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class PCCAPIFPEFE : IDAJLBKGAIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool IIKGJPNBKKO;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD946A0", Offset = "0xD92CA0", VA = "0x180D946A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xE83B20", Offset = "0xE82120", VA = "0x180E83B20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x8422380", Offset = "0x8420980", VA = "0x188422380")]
	public void LJDCNOCKLGC(ushort ENFIFICLHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x8422320", Offset = "0x8420920", VA = "0x188422320")]
	public void LJDCNOCKLGC(ushort ENFIFICLHHP, ushort MIKBHMHMEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8420A40", Offset = "0x841F040", VA = "0x188420A40")]
	public PCCAPIFPEFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class MNMMCODIKJM<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class EMGAKECJIHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode CCKLBDLJPNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode IGDHFGFJBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public OOBPLHACFDE DBPGJLKPCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<OOBPLHACFDE> NFNMCGCDANJ;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EMGAKECJIHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct OOBPLHACFDE : IComparable<OOBPLHACFDE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int DLELGMMBCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant POCDKPFJPFL;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1953810", Offset = "0x1951E10", VA = "0x181953810")]
		public OOBPLHACFDE(int DLELGMMBCCC, TClaimant POCDKPFJPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B9CAA0", Offset = "0x5B9B0A0", VA = "0x185B9CAA0")]
		public bool KKPECFFLNJM([In] OOBPLHACFDE IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B9CB00", Offset = "0x5B9B100", VA = "0x185B9CB00")]
		public bool LOLAIBCDFHH([In] OOBPLHACFDE IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B9CA90", Offset = "0x5B9B090", VA = "0x185B9CA90", Slot = "4")]
		public int CompareTo(OOBPLHACFDE IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5B9CB10", Offset = "0x5B9B110", VA = "0x185B9CB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum JNOPIAHPEAC
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class BMFHDNMEHLN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public MNMMCODIKJM<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x101AE80", Offset = "0x1019480", VA = "0x18101AE80")]
		[DebuggerHidden]
		public BMFHDNMEHLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B310", Offset = "0x6A19910", VA = "0x186A1B310", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B4D0", Offset = "0x6A19AD0", VA = "0x186A1B4D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B3F0", Offset = "0x6A199F0", VA = "0x186A1B3F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4F9D5E0", Offset = "0x4F9BBE0", VA = "0x184F9D5E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly LKFCFHEAHEC<EMGAKECJIHG> LLIBALCAHDJ;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly LKFCFHEAHEC<List<OOBPLHACFDE>> PCPICLFKGHL;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int AEPMKAKNIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> DBIJLLFCJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, EMGAKECJIHG> PHLAIDEKEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private JNOPIAHPEAC JDJJDFOGKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool OPDBEINFGEH;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KHLABIBIDLF(TNode CFHHNIJODJI);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LODAANJFPCG(TNode CFHHNIJODJI, TClaimant FLAPPAMADNJ, TClaimant BAHHEJHMPGL);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x59810A0", Offset = "0x597F6A0", VA = "0x1859810A0")]
	public MNMMCODIKJM(JNOPIAHPEAC JDJJDFOGKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x597F950", Offset = "0x597DF50", VA = "0x18597F950")]
	public void BJHAFLNECDP(TNode CFHHNIJODJI, TNode GHOEBAIBIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x597FA50", Offset = "0x597E050", VA = "0x18597FA50")]
	public void CBGBLMGJOHG(TClaimant POCDKPFJPFL, TNode NJGOJJOPCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x597FB70", Offset = "0x597E170", VA = "0x18597FB70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x59800A0", Offset = "0x597E6A0", VA = "0x1859800A0")]
	private void FILPFAJDHDA(TClaimant POCDKPFJPFL, TNode KDNBLPFDONE, TNode NJGOJJOPCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x597F9E0", Offset = "0x597DFE0", VA = "0x18597F9E0")]
	private int CAPLPJCJPHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5980390", Offset = "0x597E990", VA = "0x185980390")]
	private void JDKIELINLCD(TClaimant POCDKPFJPFL, TNode NDDFMKKMBOC, TNode KABCEGDMAJC, int CCAIEBFPPPA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5980BD0", Offset = "0x597F1D0", VA = "0x185980BD0")]
	private void OBAKHMHGFEJ(OOBPLHACFDE GDPIFLHIFEP, EMGAKECJIHG EBEOEHAALNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x59806D0", Offset = "0x597ECD0", VA = "0x1859806D0")]
	private void JMMHCMMOAOD(TClaimant POCDKPFJPFL, TNode NDDFMKKMBOC, TNode KABCEGDMAJC, int CCAIEBFPPPA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5980DD0", Offset = "0x597F3D0", VA = "0x185980DD0")]
	private void PAOMODIAEDE(OOBPLHACFDE GDPIFLHIFEP, TNode CFHHNIJODJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x59809B0", Offset = "0x597EFB0", VA = "0x1859809B0")]
	private void LEFEMJCNLNG(OOBPLHACFDE GDPIFLHIFEP, EMGAKECJIHG EBEOEHAALNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5980AA0", Offset = "0x597F0A0", VA = "0x185980AA0")]
	private void NAFDJOOGNKH(EMGAKECJIHG EBEOEHAALNF, bool OIGMKMNJEHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x597FD40", Offset = "0x597E340", VA = "0x18597FD40")]
	private void EGBBJEIPHGO(EMGAKECJIHG EBEOEHAALNF, TNode GHOEBAIBIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x59802B0", Offset = "0x597E8B0", VA = "0x1859802B0")]
	[IteratorStateMachine(typeof(MNMMCODIKJM<, >.BMFHDNMEHLN))]
	private IEnumerable<TNode> IADIELIFFGH(TNode NDDFMKKMBOC, TNode KABCEGDMAJC, bool BHALGPMIGHP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x597F860", Offset = "0x597DE60", VA = "0x18597F860")]
	private EMGAKECJIHG BGJAJNIKNPA(TNode CFHHNIJODJI, TNode IGDHFGFJBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5980140", Offset = "0x597E740", VA = "0x185980140")]
	private EMGAKECJIHG HEBHMNFNPFH(TNode CFHHNIJODJI, TNode IGDHFGFJBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5980C60", Offset = "0x597F260", VA = "0x185980C60")]
	private void ODEHMJADNJG(EMGAKECJIHG EBEOEHAALNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FHHAJIIIOLL<T> : IEnumerable<FHHAJIIIOLL<T>.OLNMCLCFONA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct OLNMCLCFONA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T FKMNCAKIOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int LEPAEEGOBDO;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class FFHBCELPNKG : IEnumerator<OLNMCLCFONA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private FHHAJIIIOLL<T> GKLIJOFCGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int LEPAEEGOBDO;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4AB3C30", Offset = "0x4AB2230", VA = "0x184AB3C30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public OLNMCLCFONA MKKCMPLEMEF
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4F3A6B0", Offset = "0x4F38CB0", VA = "0x184F3A6B0", Slot = "4")]
			get
			{
				return default(OLNMCLCFONA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A670", Offset = "0x4F38C70", VA = "0x184F3A670")]
		public FFHBCELPNKG(FHHAJIIIOLL<T> GKLIJOFCGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A5F0", Offset = "0x4F38BF0", VA = "0x184F3A5F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4B1D4F0", Offset = "0x4B1BAF0", VA = "0x184B1D4F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1316140", Offset = "0x1314740", VA = "0x181316140", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct EFKMGLJAKHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool NMEHAGDLHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T FKMNCAKIOFK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int LKPNIALJOOM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> PPIICAOGPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private EFKMGLJAKHM[] AINIILJKGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int BMNFCGCJOMD;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int NEACIJGNOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xC3A7A0", Offset = "0xC38DA0", VA = "0x180C3A7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1093000", Offset = "0x1091600", VA = "0x181093000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4568100", Offset = "0x4566700", VA = "0x184568100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4F40110", Offset = "0x4F3E710", VA = "0x184F40110")]
	public FHHAJIIIOLL(int FAALOCBOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4F401F0", Offset = "0x4F3E7F0", VA = "0x184F401F0")]
	public FHHAJIIIOLL(OLNMCLCFONA[] JHJPKHMCBMH, bool PJNMGGNENDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4F3F820", Offset = "0x4F3DE20", VA = "0x184F3F820")]
	public int ICCAGDJGMIJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4F3F5B0", Offset = "0x4F3DBB0", VA = "0x184F3F5B0")]
	private int DNNDCNKFLFF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4F3F7C0", Offset = "0x4F3DDC0", VA = "0x184F3F7C0", Slot = "6")]
	protected virtual uint GFLBIEIFEBA(uint PDDACHIAKKM, T FKMNCAKIOFK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FF30", Offset = "0x4F3E530", VA = "0x184F3FF30")]
	public bool OGBDKKBCIDJ(T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FE60", Offset = "0x4F3E460", VA = "0x184F3FE60")]
	public int NEPHAMINJHF(T FKMNCAKIOFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FFD0", Offset = "0x4F3E5D0", VA = "0x184F3FFD0")]
	public T PICMHBILFNN(int LEPAEEGOBDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FD70", Offset = "0x4F3E370", VA = "0x184F3FD70")]
	public bool ILMKKBDBIHH(T FKMNCAKIOFK, bool DKIPGMGPMLD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FB10", Offset = "0x4F3E110", VA = "0x184F3FB10")]
	public bool ILMKKBDBIHH(T FKMNCAKIOFK, int LEPAEEGOBDO, bool DKIPGMGPMLD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4F3FDC0", Offset = "0x4F3E3C0", VA = "0x184F3FDC0")]
	private int MKGICLHJFLH(int JNIDLJHCIED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4F40090", Offset = "0x4F3E690", VA = "0x184F40090", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4F40090", Offset = "0x4F3E690", VA = "0x184F40090", Slot = "4")]
	private IEnumerator<OLNMCLCFONA> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class LKFCFHEAHEC<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> KKEHMECDMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> OEHPFLHLFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int IMMMFHBPDIB;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x571FE90", Offset = "0x571E490", VA = "0x18571FE90")]
	public static LKFCFHEAHEC<T> LIMKHNHINPK(int FAALOCBOHHG = 0, int IMMMFHBPDIB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x571FD90", Offset = "0x571E390", VA = "0x18571FD90")]
	public static LKFCFHEAHEC<T> EIGPJEFNJOM(int FAALOCBOHHG = 0, int IMMMFHBPDIB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5720590", Offset = "0x571EB90", VA = "0x185720590")]
	public LKFCFHEAHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x57203F0", Offset = "0x571E9F0", VA = "0x1857203F0")]
	public LKFCFHEAHEC(int FAALOCBOHHG, int IMMMFHBPDIB = int.MaxValue, bool PLJHKOPBJPD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x571FF70", Offset = "0x571E570", VA = "0x18571FF70")]
	public T PEPFMPMNHIJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5720110", Offset = "0x571E710", VA = "0x185720110")]
	public void PILMPNHBFAM(T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x571FB60", Offset = "0x571E160", VA = "0x18571FB60")]
	private void BEDIBEEGDIA(T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x571FE70", Offset = "0x571E470", VA = "0x18571FE70")]
	private void KPNCCBMLJCG(T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x571FC40", Offset = "0x571E240", VA = "0x18571FC40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x57201F0", Offset = "0x571E7F0", VA = "0x1857201F0")]
	private void PPPPGJBHGFO(IEnumerable<T> DMJEPOICLBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class BIKOBKLHDFC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> KMJJPAEMNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T AGLFPANCBLM;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T ICDAKDCBCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x693EDF0", Offset = "0x693D3F0", VA = "0x18693EDF0")]
	public bool GKJOFPFBKFG(T FKMNCAKIOFK, int DLELGMMBCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4AAE960", Offset = "0x4AACF60", VA = "0x184AAE960")]
	public bool LOLEOCABCAK(int DLELGMMBCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x693F080", Offset = "0x693D680", VA = "0x18693F080")]
	public T JLOAHAKFHMJ(int ALMOGMJHIIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x693F2D0", Offset = "0x693D8D0", VA = "0x18693F2D0")]
	private bool PJODBCBBOPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x693F280", Offset = "0x693D880", VA = "0x18693F280")]
	public bool NBJEBNMBDKD(int DLELGMMBCCC, [Out] T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x693F460", Offset = "0x693DA60", VA = "0x18693F460")]
	public BIKOBKLHDFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class EJEENMINJIC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct PLANOJCJJBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T FAGODIAEODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int LFLEHKJBBGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<PLANOJCJJBF> OJKALEKNNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T NKBPHOHPICM;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4568100", Offset = "0x4566700", VA = "0x184568100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4A81D00", Offset = "0x4A80300", VA = "0x184A81D00")]
	public bool DIIFLEHJKPJ(T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4A82490", Offset = "0x4A80A90", VA = "0x184A82490")]
	public void KMLBEHGKDFG(T FKMNCAKIOFK, int DLELGMMBCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4A820E0", Offset = "0x4A806E0", VA = "0x184A820E0")]
	public bool HCDNAOEAAEJ(T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4A82940", Offset = "0x4A80F40", VA = "0x184A82940")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4A82590", Offset = "0x4A80B90", VA = "0x184A82590")]
	public T LMIOKILJLEC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4A827B0", Offset = "0x4A80DB0", VA = "0x184A827B0")]
	protected void MBIIGOPGIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4A829A0", Offset = "0x4A80FA0", VA = "0x184A829A0")]
	public EJEENMINJIC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x8422520", Offset = "0x8420B20", VA = "0x188422520")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x84227F0", Offset = "0x8420DF0", VA = "0x1884227F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x8422700", Offset = "0x8420D00", VA = "0x188422700")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x8422470", Offset = "0x8420A70", VA = "0x188422470")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x8422740", Offset = "0x8420D40", VA = "0x188422740")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x8422650", Offset = "0x8420C50", VA = "0x188422650")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x84223E0", Offset = "0x84209E0", VA = "0x1884223E0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F760", Offset = "0x5E7DD60", VA = "0x185E7F760", Slot = "4")]
		public virtual T LDHLAPLLNGM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface OPOOBKLHJCF
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache JLHKEJCJOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct DDHDNBKCAGB<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> AHJLBOEGGKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool CCFMJNHJKPH;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1AB9730", Offset = "0x1AB7D30", VA = "0x181AB9730")]
			public DDHDNBKCAGB(List<Component> AHJLBOEGGKN, bool CCFMJNHJKPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x45A0970", Offset = "0x459EF70", VA = "0x1845A0970")]
			public BIJEGONIIPN<T> DKMCAGKLCHH()
			{
				return default(BIJEGONIIPN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x45A09E0", Offset = "0x459EFE0", VA = "0x1845A09E0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x45A09E0", Offset = "0x459EFE0", VA = "0x1845A09E0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct BIJEGONIIPN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> AHJLBOEGGKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool CCFMJNHJKPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int LEPAEEGOBDO;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T MKKCMPLEMEF
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x693EC80", Offset = "0x693D280", VA = "0x18693EC80", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x693EC10", Offset = "0x693D210", VA = "0x18693EC10", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x693EC50", Offset = "0x693D250", VA = "0x18693EC50")]
			public BIJEGONIIPN(List<Component> AHJLBOEGGKN, bool CCFMJNHJKPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x693EB50", Offset = "0x693D150", VA = "0x18693EB50", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x693EB60", Offset = "0x693D160", VA = "0x18693EB60", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x4B08C20", Offset = "0x4B07220", VA = "0x184B08C20", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8424250", Offset = "0x8422850", VA = "0x188424250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8424050", Offset = "0x8422650", VA = "0x188424050")]
		private void LJDCNOCKLGC(GameObject KDNOBMEOLJE, bool MKJGBAFLMBJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8423FC0", Offset = "0x84225C0", VA = "0x188423FC0")]
		public static void LJDCNOCKLGC(GameObject KDNOBMEOLJE, ToolHierarchyCache GMBMBGKOJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8423BB0", Offset = "0x84221B0", VA = "0x188423BB0")]
		public void FOFIENKJBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x410E220", Offset = "0x410C820", VA = "0x18410E220")]
		public void DALENCKGFHF<T>(Action<T> CBDPHPPPDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x410E440", Offset = "0x410CA40", VA = "0x18410E440")]
		public T OPBBMOICBCB<T>(bool CCFMJNHJKPH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x410E160", Offset = "0x410C760", VA = "0x18410E160")]
		public DDHDNBKCAGB<T> CBGOCEDPKFE<T>(bool CCFMJNHJKPH = false) where T : class
		{
			return default(DDHDNBKCAGB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8423C30", Offset = "0x8422230", VA = "0x188423C30")]
		public List<Component> HJBHLDDCEHF(Type EHLAHNIAPLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8423B30", Offset = "0x8422130", VA = "0x188423B30", Slot = "4")]
		public bool Equals(ToolHierarchyCache POMPNNDHCKO, ToolHierarchyCache JLAHKMCOIFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8423BC0", Offset = "0x84221C0", VA = "0x188423BC0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NDBJJGOPOFO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class JDIGLEFOFDF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int FAALOCBOHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int FCHADEOOLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> HIGCIOAFPJH;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4F303C0", Offset = "0x4F2E9C0", VA = "0x184F303C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T PELAIAPNCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x54A8D10", Offset = "0x54A7310", VA = "0x1854A8D10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T CNIKJHMDPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x54A8E50", Offset = "0x54A7450", VA = "0x1854A8E50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T OGDCHFGABNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x54A9140", Offset = "0x54A7740", VA = "0x1854A9140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x54A9280", Offset = "0x54A7880", VA = "0x1854A9280")]
	public JDIGLEFOFDF(int FAALOCBOHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x54A8FD0", Offset = "0x54A75D0", VA = "0x1854A8FD0")]
	public void KMLBEHGKDFG(T OJJOGGKIHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x54A91E0", Offset = "0x54A77E0", VA = "0x1854A91E0")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x54A8B10", Offset = "0x54A7110", VA = "0x1854A8B10")]
	public void ABONNNFCGDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x54A9220", Offset = "0x54A7820", VA = "0x1854A9220")]
	public void PGJGAACGLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x54A91D0", Offset = "0x54A77D0", VA = "0x1854A91D0")]
	public void NGCFGOCABGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x54A8BE0", Offset = "0x54A71E0", VA = "0x1854A8BE0")]
	public List<T> CMAODDCADAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class BJGHJEFJAHK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct PCGICKNNFFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int LFLEHKJBBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T FAGODIAEODP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, PCGICKNNFFF> KMJJPAEMNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> GPJGDFAGDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T AGLFPANCBLM;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T ICDAKDCBCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xEAD290", Offset = "0xEAB890", VA = "0x180EAD290", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x694D750", Offset = "0x694BD50", VA = "0x18694D750", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool OAAKNFDOPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x694D1A0", Offset = "0x694B7A0", VA = "0x18694D1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object ABICCBOLCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x694CF90", Offset = "0x694B590", VA = "0x18694CF90")]
	public bool GKJOFPFBKFG(T FKMNCAKIOFK, object HNGIMMGBLII, int DLELGMMBCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x694D110", Offset = "0x694B710", VA = "0x18694D110")]
	public bool LOLEOCABCAK(object HNGIMMGBLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x694D1F0", Offset = "0x694B7F0", VA = "0x18694D1F0")]
	public bool NBJEBNMBDKD(object HNGIMMGBLII, [Out] T FKMNCAKIOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x694D700", Offset = "0x694BD00", VA = "0x18694D700")]
	public void OOIGDCNPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x694EC00", Offset = "0x694D200", VA = "0x18694EC00")]
	private bool PJODBCBBOPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x694F550", Offset = "0x694DB50", VA = "0x18694F550")]
	public BJGHJEFJAHK()
	{
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
