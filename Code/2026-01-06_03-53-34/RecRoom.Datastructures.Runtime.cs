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
using RecRoom.Async;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using RecRoom.DataStructures.Hashing;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Caching;
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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8308350", Offset = "0x8306D50", VA = "0x188308350")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CompactArrayDrawerAttribute : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F7B0F0", Offset = "0x1F79AF0", VA = "0x181F7B0F0")]
	public CompactArrayDrawerAttribute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, GKXLWMDZWGG, PSVWBXAFMWS, ISerializationCallbackReceiver
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
	public byte[] KUCRTEFHMMU
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] DLZBFDWXFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object JPKUYULHDWV
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB5A370", Offset = "0xB58D70", VA = "0x180B5A370", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash hash);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xBF0BD0", Offset = "0xBEF5D0", VA = "0x180BF0BD0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float YKGIONLOLWS;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float UFAWYHSUUSL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x830A040", Offset = "0x8308A40", VA = "0x18830A040")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x830A000", Offset = "0x8308A00", VA = "0x18830A000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x830A080", Offset = "0x8308A80", VA = "0x18830A080")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x830A1A0", Offset = "0x8308BA0", VA = "0x18830A1A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x830A100", Offset = "0x8308B00", VA = "0x18830A100")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB066D0", Offset = "0xB050D0", VA = "0x180B066D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB10910", Offset = "0xB0F310", VA = "0x180B10910")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8309FE0", Offset = "0x83089E0", VA = "0x188309FE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBE7070", Offset = "0xBE5A70", VA = "0x180BE7070")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83099C0", Offset = "0x83083C0", VA = "0x1883099C0")]
	public void CopyBounds(SavedExtents other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8309F40", Offset = "0x8308940", VA = "0x188309F40")]
	public void SetLocalSpaceBounds(Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1457F70", Offset = "0x1456970", VA = "0x181457F70")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8309F30", Offset = "0x8308930", VA = "0x188309F30")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83099F0", Offset = "0x83083F0", VA = "0x1883099F0")]
	private void EMXZTVXSVUD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8309CB0", Offset = "0x83086B0", VA = "0x188309CB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83093A0", Offset = "0x8307DA0", VA = "0x1883093A0")]
	public static void CalculateLocalBoundsFor(GameObject gameObject, [Out] Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8309BF0", Offset = "0x83085F0", VA = "0x188309BF0")]
	private static void HSVIWDSWUTW(Bounds a, Color b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8309F60", Offset = "0x8308960", VA = "0x188309F60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB5110", Offset = "0xAB3B10", VA = "0x180AB5110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAC0440", Offset = "0xABEE40", VA = "0x180AC0440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1962010", Offset = "0x1960A10", VA = "0x181962010")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F20040", Offset = "0x5F1EA40", VA = "0x185F20040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "4")]
	public virtual void KMPUSPCYDYZ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
	[SerializeField]
	[CompactArrayDrawer]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F1D8A0", Offset = "0x5F1C2A0", VA = "0x185F1D8A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F1C6A0", Offset = "0x5F1B0A0", VA = "0x185F1C6A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1DC20", Offset = "0x5F1C620", VA = "0x185F1DC20")]
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
	private sealed class PHEUSJQEBDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> YUNFSFYTRCQ;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PHEUSJQEBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5BDEA30", Offset = "0x5BDD430", VA = "0x185BDEA30")]
		internal int ZZMEGPWHZUN(TKeyVal a, TKeyVal b)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[CompactArrayDrawer]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> KYGTMORJDLD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46F4520", Offset = "0x46F2F20", VA = "0x1846F4520", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46F45A0", Offset = "0x46F2FA0", VA = "0x1846F45A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46F42A0", Offset = "0x46F2CA0", VA = "0x1846F42A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey key]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x46F4350", Offset = "0x46F2D50", VA = "0x1846F4350", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> CLMEDLGQFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x46F3D70", Offset = "0x46F2770", VA = "0x1846F3D70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x46F39E0", Offset = "0x46F23E0", VA = "0x1846F39E0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x46F2D30", Offset = "0x46F1730", VA = "0x1846F2D30", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x46F2C70", Offset = "0x46F1670", VA = "0x1846F2C70", Slot = "14")]
	protected virtual string MMXLBNBCUDK(TKeyVal a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46F2A50", Offset = "0x46F1450", VA = "0x1846F2A50", Slot = "4")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46F3E60", Offset = "0x46F2860", VA = "0x1846F3E60", Slot = "5")]
	public bool TryGetValue(TKey key, [Out] TVal value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x46F2B30", Offset = "0x46F1530", VA = "0x1846F2B30", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46F2B30", Offset = "0x46F1530", VA = "0x1846F2B30", Slot = "11")]
	private IEnumerator WFEYQSZVQHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x46F41C0", Offset = "0x46F2BC0", VA = "0x1846F41C0")]
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
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC3E200", Offset = "0xC3CC00", VA = "0x180C3E200")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC3E220", Offset = "0xC3CC20", VA = "0x180C3E220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[CompactArrayDrawer]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5F223B0", Offset = "0x5F20DB0", VA = "0x185F223B0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5F22010", Offset = "0x5F20A10", VA = "0x185F22010", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5F21680", Offset = "0x5F20080", VA = "0x185F21680", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class PRAIZOTBMWM<a>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct BufferEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public a Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float Timestamp;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int UJTUPJTKJGF = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float ZBBGSONYWHY = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly BufferEntry[] YNZCMBSTFEU;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int FOEQARGKMGN;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float VZPVMCUDOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB37460", Offset = "0xB35E60", VA = "0x180B37460")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB377F0", Offset = "0xB361F0", VA = "0x180B377F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public a JXHRPRGMXPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x17038B0", Offset = "0x17022B0", VA = "0x1817038B0")]
		[CompilerGenerated]
		get
		{
			return (a)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE1860", Offset = "0x5BE0260", VA = "0x185BE1860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1A20", Offset = "0x5BE0420", VA = "0x185BE1A20")]
	protected PRAIZOTBMWM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1890", Offset = "0x5BE0290", VA = "0x185BE1890")]
	protected PRAIZOTBMWM(int a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5BE15F0", Offset = "0x5BDFFF0", VA = "0x185BE15F0")]
	public void Add(float time, a value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool UBBEAUPYANV(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool YPMSJOFKOIM(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5BE1680", Offset = "0x5BE0080", VA = "0x185BE1680")]
	public void Clear()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JXWEECPCCKV : PRAIZOTBMWM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8306C30", Offset = "0x8305630", VA = "0x188306C30", Slot = "4")]
	public override bool UBBEAUPYANV(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8306D90", Offset = "0x8305790", VA = "0x188306D90", Slot = "5")]
	public override bool YPMSJOFKOIM(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8306ED0", Offset = "0x83058D0", VA = "0x188306ED0")]
	public JXWEECPCCKV()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CFD0", Offset = "0x3A9B9D0", VA = "0x183A9CFD0")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D0D0", Offset = "0x3A9BAD0", VA = "0x183A9D0D0")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x58E6A00", Offset = "0x58E5400", VA = "0x1858E6A00")]
	internal static int YDKNOJSHCYW(int a, int b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7523090", Offset = "0x7521A90", VA = "0x187523090")]
	internal static int YDKNOJSHCYW(int a, int b, int c)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class Tuple<T1, T2> : IComparable<Tuple<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 SDDFOXDZQQH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 SDIMMDXXABQ;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61812C0", Offset = "0x617FCC0", VA = "0x1861812C0")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61796E0", Offset = "0x61780E0", VA = "0x1861796E0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x617ABA0", Offset = "0x61795A0", VA = "0x18617ABA0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x617B160", Offset = "0x6179B60", VA = "0x18617B160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6180B50", Offset = "0x617F550", VA = "0x186180B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Tuple<T1, T2, T3> : IComparable<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 SDDFOXDZQQH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 SDIMMDXXABQ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 SDNTJKRUJMZ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61868D0", Offset = "0x61852D0", VA = "0x1861868D0")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6182650", Offset = "0x6181050", VA = "0x186182650", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6182E00", Offset = "0x6181800", VA = "0x186182E00", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6183720", Offset = "0x6182120", VA = "0x186183720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6186750", Offset = "0x6185150", VA = "0x186186750", Slot = "3")]
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
	public AnimationCurve FEGRDYIPIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T NJXLXGWWXEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1195E10", Offset = "0x1194810", VA = "0x181195E10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T GIGLLOYRSCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T GJDRZFRFPRC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D34D90", Offset = "0x2D33790", VA = "0x182D34D90")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2D34BA0", Offset = "0x2D335A0", VA = "0x182D34BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float XBKXFJJVYBV
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xBC1D00", Offset = "0xBC0700", VA = "0x180BC1D00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6426CA0", Offset = "0x64256A0", VA = "0x186426CA0")]
	public T YLPLCMSXADO(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6426650", Offset = "0x6425050", VA = "0x186426650")]
	public T QYZNFONBIVY(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T QJINUZSQSJU(T a, T b, float c);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x83069B0", Offset = "0x83053B0", VA = "0x1883069B0", Slot = "4")]
	protected override float QJINUZSQSJU(float a, float b, float c)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x83069F0", Offset = "0x83053F0", VA = "0x1883069F0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x17A67E0", Offset = "0x17A51E0", VA = "0x1817A67E0", Slot = "4")]
	protected override Vector3 QJINUZSQSJU(Vector3 a, Vector3 b, float c)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x830B1E0", Offset = "0x8309BE0", VA = "0x18830B1E0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8306850", Offset = "0x8305250", VA = "0x188306850", Slot = "4")]
	protected override Color QJINUZSQSJU(Color a, Color b, float c)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8306910", Offset = "0x8305310", VA = "0x188306910")]
	public ColorValueCurve()
	{
	}
}
namespace Structures.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class OEOFVSTDUUB : OUZJHNVVKXT<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8308D00", Offset = "0x8307700", VA = "0x188308D00")]
		public OEOFVSTDUUB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8308C90", Offset = "0x8307690", VA = "0x188308C90", Slot = "6")]
		protected override uint PLWVMSTNVGV(uint a, string b)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class PTIVZBMQVNP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly IDisposable GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public PTIVZBMQVNP()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct AwaitableRpc<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> _roundTripRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int _lastActorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int _requestId;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x58E9490", Offset = "0x58E7E90", VA = "0x1858E9490")]
		private AwaitableRpc(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> roundTripRequests, int lastActorId, int requestId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5E10", Offset = "0x6FF4810", VA = "0x186FF5E10")]
		public static AwaitableRpc<T> New()
		{
			return default(AwaitableRpc<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6FF53B0", Offset = "0x6FF3DB0", VA = "0x186FF53B0")]
		public (int, int, Task<T>) HOFKRDYMPOO(int a, [Optional] CancellationToken b, double c = 60.0)
		{
			return default((int, int, Task<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF64E0", Offset = "0x6FF4EE0", VA = "0x186FF64E0")]
		public void PLKUSNMZPTT(int a, int b, [In] T result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class NADPVVKVCSG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8307160", Offset = "0x8305B60", VA = "0x188307160")]
		public static AwaitableRpc<None> New()
		{
			return default(AwaitableRpc<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83071B0", Offset = "0x8305BB0", VA = "0x1883071B0")]
		public static void PLKUSNMZPTT([In] this AwaitableRpc<None> self, int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class WZQYDZQAXYA<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Dictionary<a, b> TKTHZOLOVBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Dictionary<b, a> WBAOLKVOVKY;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x5AC8100", Offset = "0x5AC6B00", VA = "0x185AC8100", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x67251E0", Offset = "0x6723BE0", VA = "0x1867251E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6725210", Offset = "0x6723C10", VA = "0x186725210", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6724F60", Offset = "0x6723960", VA = "0x186724F60", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6725280", Offset = "0x6723C80", VA = "0x186725280", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public a this[b key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6725020", Offset = "0x6723A20", VA = "0x186725020")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6723320", Offset = "0x6721D20", VA = "0x186723320", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6724A90", Offset = "0x6723490", VA = "0x186724A90", Slot = "20")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6722C20", Offset = "0x6721620", VA = "0x186722C20", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6722B40", Offset = "0x6721540", VA = "0x186722B40", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x67234B0", Offset = "0x6721EB0", VA = "0x1867234B0", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6723550", Offset = "0x6721F50", VA = "0x186723550", Slot = "16")]
		public bool Contains(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6724780", Offset = "0x6723180", VA = "0x186724780", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6724780", Offset = "0x6723180", VA = "0x186724780", Slot = "18")]
		public bool Remove(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x67248C0", Offset = "0x67232C0", VA = "0x1867248C0", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6723C00", Offset = "0x6722600", VA = "0x186723C00", Slot = "19")]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6723770", Offset = "0x6722170", VA = "0x186723770", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6723140", Offset = "0x6721B40", VA = "0x186723140")]
		public bool CIWAHGAOAZX(b a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x67237D0", Offset = "0x67221D0", VA = "0x1867237D0")]
		private void FLBVCFRTKOP(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6724240", Offset = "0x6722C40", VA = "0x186724240")]
		private void RIYPJJKWNKM(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6724130", Offset = "0x6722B30", VA = "0x186724130")]
		private bool PWEGRCXAVKO(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6724B30", Offset = "0x6723530", VA = "0x186724B30")]
		public WZQYDZQAXYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class JGBQVGSAYZZ<a> : IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private JGBQVGSAYZZ<a> buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private a current;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public a Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x12C21C0", Offset = "0x12C0BC0", VA = "0x1812C21C0", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x4723790", Offset = "0x4722190", VA = "0x184723790", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x4724F40", Offset = "0x4723940", VA = "0x184724F40")]
			public Enumerator(JGBQVGSAYZZ<a> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4722EC0", Offset = "0x47218C0", VA = "0x184722EC0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4724D80", Offset = "0x4723780", VA = "0x184724D80", Slot = "8")]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x4723720", Offset = "0x4722120", VA = "0x184723720")]
			private void NGOAAVGOJWX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private a[] KAEWAGQSVZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int DJEOZNCUFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int ZKCNEHJTKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int version;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x51691C0", Offset = "0x5167BC0", VA = "0x1851691C0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x51694C0", Offset = "0x5167EC0", VA = "0x1851694C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5169610", Offset = "0x5168010", VA = "0x185169610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5169140", Offset = "0x5167B40", VA = "0x185169140")]
		public JGBQVGSAYZZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5166490", Offset = "0x5164E90", VA = "0x185166490")]
		public void Add(a t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5167AE0", Offset = "0x51664E0", VA = "0x185167AE0")]
		public void IBJMPOPJLXJ(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5166920", Offset = "0x5165320", VA = "0x185166920")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5168CE0", Offset = "0x51676E0", VA = "0x185168CE0")]
		public void NIWWWQBAYYC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5166A90", Offset = "0x5165490", VA = "0x185166A90")]
		public void CopyTo(a[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5166D20", Offset = "0x5165720", VA = "0x185166D20")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5168F30", Offset = "0x5167930", VA = "0x185168F30", Slot = "4")]
		private IEnumerator<a> XHEIENLLPFX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5168F30", Offset = "0x5167930", VA = "0x185168F30", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5166180", Offset = "0x5164B80", VA = "0x185166180")]
		private int ASNQNQAHLSA(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5168C00", Offset = "0x5167600", VA = "0x185168C00")]
		private int KBINBEDDTCY(int a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class WHEAMGXERIC<a, b> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public delegate Task<b> RequestProcessor(a request, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public enum ProcessMethod
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			FirstInFirstOut,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			LastInFirstOut
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public class CTVGYXMYBVZ
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private const float MEWDEYGPQZB = 60f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TimeSpan YIBGMMIKCOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public int OOCMTRKTNVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public ProcessMethod BXKASCQBZHX;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly CTVGYXMYBVZ WUXFTMOSJKM;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public float YMSLFWNIDNO
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x3DA4140", Offset = "0x3DA2B40", VA = "0x183DA4140")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public TimeSpan FVUHSDDZXTV
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
				get
				{
					return default(TimeSpan);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x3DA45D0", Offset = "0x3DA2FD0", VA = "0x183DA45D0")]
			public CTVGYXMYBVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private readonly struct QueueItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public readonly a request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public readonly CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public readonly TaskCompletionSource<b> taskCompletionSource;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5C5A810", Offset = "0x5C59210", VA = "0x185C5A810")]
			public QueueItem(a request, TaskCompletionSource<b> taskCompletionSource, CancellationToken cancellationToken)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private struct <DequeueItemAndRun>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public WHEAMGXERIC<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private QueueItem <req>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x4DE6820", Offset = "0x4DE5220", VA = "0x184DE6820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x4DE80A0", Offset = "0x4DE6AA0", VA = "0x184DE80A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct <StartQueueProcess>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public WHEAMGXERIC<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5330050", Offset = "0x532EA50", VA = "0x185330050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x5330860", Offset = "0x532F260", VA = "0x185330860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CancellationTokenSource FGALAGMKHSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly List<QueueItem> NMGDOLLOSOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly CTVGYXMYBVZ GBRQEOFAOUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly RequestProcessor LGOOANJUIYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Task MPLUFKLXUYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int HLIENSMQHAA;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x670E5F0", Offset = "0x670CFF0", VA = "0x18670E5F0")]
		public WHEAMGXERIC(RequestProcessor a, [Optional] CTVGYXMYBVZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x670C640", Offset = "0x670B040", VA = "0x18670C640")]
		public Task<b> DZHRPJBNUPN(a a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x670D070", Offset = "0x670BA70", VA = "0x18670D070")]
		private void EKRBMLINKZA(QueueItem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x670E250", Offset = "0x670CC50", VA = "0x18670E250")]
		[AsyncStateMachine(typeof(WHEAMGXERIC<, >.<StartQueueProcess>d__12))]
		private Task YOSQUHWTHBT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x670D9B0", Offset = "0x670C3B0", VA = "0x18670D9B0")]
		private QueueItem RYFAXBJHJKP()
		{
			return default(QueueItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x670D790", Offset = "0x670C190", VA = "0x18670D790")]
		[AsyncStateMachine(typeof(WHEAMGXERIC<, >.<DequeueItemAndRun>d__14))]
		private Task RLELAOSNYJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x670D4A0", Offset = "0x670BEA0", VA = "0x18670D4A0")]
		private void GZCSOSSGNBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x670CCA0", Offset = "0x670B6A0", VA = "0x18670CCA0", Slot = "4")]
		public void Dispose()
		{
		}
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
namespace RecRoom.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class BQTNMKQINIM<a> : IList<a>, ICollection<a>, IEnumerable<a>, IEnumerable, IReadOnlyList<a>, IReadOnlyCollection<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly List<a> FATBJTFFTFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private HashSet<a> UXAYBZEOTND;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2519530", Offset = "0x2517F30", VA = "0x182519530", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x70DDE00", Offset = "0x70DC800", VA = "0x1870DDE00", Slot = "18")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x70DDE30", Offset = "0x70DC830", VA = "0x1870DDE30", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x70DCB30", Offset = "0x70DB530", VA = "0x1870DCB30", Slot = "11")]
		public void Add(a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x70DD610", Offset = "0x70DC010", VA = "0x1870DD610")]
		public bool MMKMTAKCVDN(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x70DDB40", Offset = "0x70DC540", VA = "0x1870DDB40", Slot = "15")]
		public bool Remove(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x70DCF00", Offset = "0x70DB900", VA = "0x1870DCF00", Slot = "16")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x70DDBC0", Offset = "0x70DC5C0", VA = "0x1870DDBC0", Slot = "17")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x70DCC80", Offset = "0x70DB680", VA = "0x1870DCC80", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x70DCDC0", Offset = "0x70DB7C0", VA = "0x1870DCDC0", Slot = "13")]
		public bool Contains(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x70DCDF0", Offset = "0x70DB7F0", VA = "0x1870DCDF0", Slot = "14")]
		public void CopyTo(a[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x70DCF70", Offset = "0x70DB970", VA = "0x1870DCF70", Slot = "6")]
		public int IndexOf(a item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x70DD090", Offset = "0x70DBA90", VA = "0x1870DD090", Slot = "7")]
		public void Insert(int index, a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x70DD700", Offset = "0x70DC100", VA = "0x1870DD700", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x70DDD20", Offset = "0x70DC720", VA = "0x1870DDD20")]
		public BQTNMKQINIM()
		{
		}
	}
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
		private Guid NOPAUJVPRGV;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2B51110", Offset = "0x2B4FB10", VA = "0x182B51110")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x830A5B0", Offset = "0x8308FB0", VA = "0x18830A5B0")]
		public SerializedGuid([In] Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x830A3B0", Offset = "0x8308DB0", VA = "0x18830A3B0")]
		public static SerializedGuid FPLVGJGTSQQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x830A540", Offset = "0x8308F40", VA = "0x18830A540")]
		public static SerializedGuid XXTMXLSPSLY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x830A430", Offset = "0x8308E30", VA = "0x18830A430")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x830A510", Offset = "0x8308F10", VA = "0x18830A510", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x830A490", Offset = "0x8308E90", VA = "0x18830A490", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x830A2E0", Offset = "0x8308CE0", VA = "0x18830A2E0", Slot = "7")]
		public bool Equals(SerializedGuid other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x830A320", Offset = "0x8308D20", VA = "0x18830A320", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x830A420", Offset = "0x8308E20", VA = "0x18830A420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x830A2B0", Offset = "0x8308CB0", VA = "0x18830A2B0", Slot = "6")]
		public int CompareTo(SerializedGuid other)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedGuidSourceAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly Type ValueRetrieveMethodType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly string ValueRetrieveMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly bool InsertEmptyChoice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly bool Disabled;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x830A240", Offset = "0x8308C40", VA = "0x18830A240")]
		public SerializedGuidSourceAttribute(Type valueRetrieveMethodType, string valueRetrieveMethod, bool insertEmptyChoice = false, bool disabled = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface DYOYNISPQUE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		int WJTGOZSACBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<a> OATMGLQSVZW(float a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool SPMCLQRMPKG(float a, a b);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class WLYASZAESSX<a> : DYOYNISPQUE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct Sample
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly a Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly float Time;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xD90410", Offset = "0xD8EE10", VA = "0x180D90410")]
			public Sample(a value, float time)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class RWUBRKPIMJK : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private a YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public WLYASZAESSX<a> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private float SAFVJFPAHJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float ATOLYARTUZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float? MSFKVRKPOSA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float? WKSLYMGAONH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int GETMFJCVUFV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int WJYVMTQIFPC;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private a BQJDXWPHEGK
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xC026D0", Offset = "0xC010D0", VA = "0x180C026D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x4DDCA70", Offset = "0x4DDB470", VA = "0x184DDCA70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x12DCEB0", Offset = "0x12DB8B0", VA = "0x1812DCEB0")]
			[DebuggerHidden]
			public RWUBRKPIMJK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5CB3B50", Offset = "0x5CB2550", VA = "0x185CB3B50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A650", Offset = "0x3D49050", VA = "0x183D4A650", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x5CB4570", Offset = "0x5CB2F70", VA = "0x185CB4570", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> XHEIENLLPFX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x5CB4220", Offset = "0x5CB2C20", VA = "0x185CB4220", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly float TNCCMHORIXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly float RVSGXWTRQFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly List<Sample> RWUFUYGUCXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int DJEOZNCUFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int WDFSVWWSAWK;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int WJTGOZSACBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xABBD70", Offset = "0xABA770", VA = "0x180ABBD70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x671B8F0", Offset = "0x671A2F0", VA = "0x18671B8F0")]
		public WLYASZAESSX(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x671B330", Offset = "0x6719D30", VA = "0x18671B330", Slot = "6")]
		public bool SPMCLQRMPKG(float a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x671B540", Offset = "0x6719F40", VA = "0x18671B540", Slot = "8")]
		public int XPRPVYFZYNS(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x671AB30", Offset = "0x6719530", VA = "0x18671AB30", Slot = "5")]
		[IteratorStateMachine(typeof(WLYASZAESSX<>.RWUBRKPIMJK))]
		public IEnumerable<a> OATMGLQSVZW(float a, float? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x671AAC0", Offset = "0x67194C0", VA = "0x18671AAC0", Slot = "7")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x671AD60", Offset = "0x6719760", VA = "0x18671AD60")]
		private void OYGKARUNRSZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x671B5A0", Offset = "0x6719FA0", VA = "0x18671B5A0")]
		private Sample YFQROXVDUGX()
		{
			return default(Sample);
		}
	}
}
namespace RecRoom.DataStructures.Times
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class StackTimer<TKey> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public readonly struct TimerEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public readonly long startTicks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public readonly long endTicks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public readonly int startFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public readonly int endFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public readonly bool isDone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private readonly string stackTrace;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6143870", Offset = "0x6142270", VA = "0x186143870")]
			public TimerEntry(long startTicks, int startFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6143840", Offset = "0x6142240", VA = "0x186143840")]
			public TimerEntry(long startTicks, long endTicks, int startFrame, int endFrame, bool isDone, string stackTrace)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x61436C0", Offset = "0x61420C0", VA = "0x1861436C0")]
			public int WBJQSTPKAUP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x61435E0", Offset = "0x6141FE0", VA = "0x1861435E0")]
			public int OQNQDMUSQOV(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6143600", Offset = "0x6142000", VA = "0x186143600")]
			public double QORISOAUDUZ()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6143540", Offset = "0x6141F40", VA = "0x186143540")]
			public TimerEntry CDRNPHFZKTO(long a, int b)
			{
				return default(TimerEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class GJROWUWUMTO : IDisposable
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000033")]
			[CompilerGenerated]
			private struct <WrapAsync>d__17<T> : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400007F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000080")]
				public AsyncTaskMethodBuilder<T> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000081")]
				public GJROWUWUMTO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public TKey key;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000083")]
				public Func<GJROWUWUMTO, Task<T>> function;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				private GJROWUWUMTO <internalTimer>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				private TaskAwaiter<T> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x54047E0", Offset = "0x54031E0", VA = "0x1854047E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x4DF3D20", Offset = "0x4DF2720", VA = "0x184DF3D20", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public readonly TKey XQUUXFGLFNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private readonly StackTimer<TKey> JDNGKJGUBIU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public readonly Log RKIUKOTABJV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private List<GJROWUWUMTO> HUWTXGSWDTM;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public string VGVZCEWAKHQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x4E3DAA0", Offset = "0x4E3C4A0", VA = "0x184E3DAA0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public IEnumerable<GJROWUWUMTO> BZMLJUYVXTK
			{
				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x4E3DB90", Offset = "0x4E3C590", VA = "0x184E3DB90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public TimerEntry TWQQWCYTIUM
			{
				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x1E80310", Offset = "0x1E7ED10", VA = "0x181E80310")]
				[CompilerGenerated]
				get
				{
					return default(TimerEntry);
				}
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x4E3DB60", Offset = "0x4E3C560", VA = "0x184E3DB60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E5C0", Offset = "0x4E3CFC0", VA = "0x184E3E5C0")]
			internal GJROWUWUMTO(StackTimer<TKey> a, TKey b, Log c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E000", Offset = "0x4E3CA00", VA = "0x184E3E000")]
			public GJROWUWUMTO TJHEECLYHLS(TKey a, [Optional] Log? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x36306D0", Offset = "0x362F0D0", VA = "0x1836306D0")]
			[AsyncStateMachine(typeof(<WrapAsync>d__17<>))]
			public Task<b> HKJRFRKQMLX<b>(TKey a, Func<GJROWUWUMTO, Task<b>> b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x4E3D8B0", Offset = "0x4E3C2B0", VA = "0x184E3D8B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ABASKJFUNRK : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public StackTimer<TKey> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> RECIBZUSAYP;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private (TKey, List<TKey>, TimerEntry) REGHZZAPXRD
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x2B51410", Offset = "0x2B4FE10", VA = "0x182B51410", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x53F0E90", Offset = "0x53EF890", VA = "0x1853F0E90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2B51440", Offset = "0x2B4FE40", VA = "0x182B51440")]
			[DebuggerHidden]
			public ABASKJFUNRK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x53F0F90", Offset = "0x53EF990", VA = "0x1853F0F90", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x53F0B70", Offset = "0x53EF570", VA = "0x1853F0B70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x53F1040", Offset = "0x53EFA40", VA = "0x1853F1040")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A650", Offset = "0x3D49050", VA = "0x183D4A650", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x53F03A0", Offset = "0x53EEDA0", VA = "0x1853F03A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> GVAGAWZYSZI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x53F1180", Offset = "0x53EFB80", VA = "0x1853F1180", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class ABFZHPZRXCT : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private List<TKey> YODSDRFNMEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public List<TKey> DBWMOCBNASH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private GJROWUWUMTO BYLVBWLTPFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public GJROWUWUMTO CLFOEQGOOOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public StackTimer<TKey> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private IEnumerator<GJROWUWUMTO> RECIBZUSAYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> REHOZGOPKJY;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			private (TKey, List<TKey>, TimerEntry) REGHZZAPXRD
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2B51410", Offset = "0x2B4FE10", VA = "0x182B51410", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0x53F3300", Offset = "0x53F1D00", VA = "0x1853F3300", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2B51440", Offset = "0x2B4FE40", VA = "0x182B51440")]
			[DebuggerHidden]
			public ABFZHPZRXCT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x53F3350", Offset = "0x53F1D50", VA = "0x1853F3350", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x53F2C20", Offset = "0x53F1620", VA = "0x1853F2C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x53F35B0", Offset = "0x53F1FB0", VA = "0x1853F35B0")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x53F37F0", Offset = "0x53F21F0", VA = "0x1853F37F0")]
			private void SONMORMKPTT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A650", Offset = "0x3D49050", VA = "0x183D4A650", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x53F1CE0", Offset = "0x53F06E0", VA = "0x1853F1CE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> GVAGAWZYSZI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x53F3850", Offset = "0x53F2250", VA = "0x1853F3850", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Action<TKey, TimerEntry, Log> GUJQGQUXIMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly Action<TKey, TimerEntry, Log> CYROWWQXVRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Action<StackTimer<TKey>, Log> DUZXNXYFNRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly GJROWUWUMTO YKDRJNLMJSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool IWZTIHAPXBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int NJQOWBYWBLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Stopwatch CTBRCSQGXUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly int GJNJOWTNZDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private string DTENEULYALL;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public GJROWUWUMTO ITNTYNVJLMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		[NotNull]
		public string VGVZCEWAKHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x5FD06A0", Offset = "0x5FCF0A0", VA = "0x185FD06A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5FD09C0", Offset = "0x5FCF3C0", VA = "0x185FD09C0")]
		public StackTimer(TKey rootKey, Log log, [Optional] int? startFrame, [Optional][CanBeNull] Stopwatch stopwatch, [Optional] Action<TKey, TimerEntry, Log> pushCallback, [Optional] Action<TKey, TimerEntry, Log> popCallback, [Optional] Action<StackTimer<TKey>, Log> disposeCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0450", Offset = "0x5FCEE50", VA = "0x185FD0450", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5FD00B0", Offset = "0x5FCEAB0", VA = "0x185FD00B0")]
		[IteratorStateMachine(typeof(StackTimer<>.ABASKJFUNRK))]
		public IEnumerable<(TKey, List<TKey>, TimerEntry)> DYDMFDEWLDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0200", Offset = "0x5FCEC00", VA = "0x185FD0200")]
		[IteratorStateMachine(typeof(StackTimer<>.ABFZHPZRXCT))]
		private IEnumerable<(TKey, List<TKey>, TimerEntry)> DYDMFDEWLDK(List<TKey> a, GJROWUWUMTO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5FD05A0", Offset = "0x5FCEFA0", VA = "0x185FD05A0")]
		private (long, int) Now()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class DQQXBUHFBUW<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b Format(StackTimer<a> timer);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected DQQXBUHFBUW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class QQKGCEDTJAR<a> : DQQXBUHFBUW<a, string>
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F0D0", Offset = "0x5C4DAD0", VA = "0x185C4F0D0")]
		private static string FYBZOHXRGKL(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F350", Offset = "0x5C4DD50", VA = "0x185C4F350", Slot = "4")]
		public override string Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F110", Offset = "0x5C4DB10", VA = "0x185C4F110")]
		public string Format(StackTimer<a> timer, [NotNull] KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract string OKMHGKUKSRT(StackTimer<a> a, [NotNull] KeyToStringFunc keyToStringFunc);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4076890", Offset = "0x4075290", VA = "0x184076890")]
		protected QQKGCEDTJAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class WGDHIEOVKWF<a> : DQQXBUHFBUW<a, Dictionary<string, string>>
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string BWXCKYCTOLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly double HROGSUKBBEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly bool CDCHUYZTMTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly int TVRYKLZSHIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ISet<string> KKXBIFNSLNW;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x670AEC0", Offset = "0x67098C0", VA = "0x18670AEC0")]
		private static string FYBZOHXRGKL(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x670C170", Offset = "0x670AB70", VA = "0x18670C170")]
		public WGDHIEOVKWF(string a = "F2", double b = 1.7976931348623157E+308, bool c = false, int d = 2147483647, [Optional] ISet<string> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x670BD50", Offset = "0x670A750", VA = "0x18670BD50", Slot = "4")]
		public override Dictionary<string, string> Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x670BDF0", Offset = "0x670A7F0", VA = "0x18670BDF0")]
		private bool IJRFPIXFKHT(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x670B5E0", Offset = "0x6709FE0", VA = "0x18670B5E0")]
		public Dictionary<string, string> Format(StackTimer<a> timer, KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x670A940", Offset = "0x6709340", VA = "0x18670A940")]
		private string AODKJHEYSHK(StringBuilder a, List<a> b, KeyToStringFunc c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x670C020", Offset = "0x670AA20", VA = "0x18670C020")]
		private static void TZQLXQPEAYM(StringBuilder a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class YWEHBBLVJTO<a> : QQKGCEDTJAR<a>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <>c__DisplayClass4_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public KeyToStringFunc keyToStringFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static YWEHBBLVJTO<a> GUPHEVFTUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly string[] NZIJLFLEELP;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3E25430", Offset = "0x3E23E30", VA = "0x183E25430")]
		private YWEHBBLVJTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3E242A0", Offset = "0x3E22CA0", VA = "0x183E242A0", Slot = "5")]
		protected override string OKMHGKUKSRT(StackTimer<a> a, KeyToStringFunc b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x3E25060", Offset = "0x3E23A60", VA = "0x183E25060")]
		[CompilerGenerated]
		internal static string PODEHITJFJP(string a, a b, <>c__DisplayClass4_0 c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class HMMPDCQBBAL : StackTimer<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class CGPLWVDWZDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public Action<HMMPDCQBBAL, Log> HOUIHRVFKXW;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CGPLWVDWZDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83067C0", Offset = "0x83051C0", VA = "0x1883067C0")]
			internal void YJJWHBGPUGZ(StackTimer<string> a, Log b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8306AF0", Offset = "0x83054F0", VA = "0x188306AF0")]
		public HMMPDCQBBAL(Log a, [Optional] string b, [Optional] int? c, [Optional] Stopwatch d, [Optional] Action<string, TimerEntry, Log> e, [Optional] Action<string, TimerEntry, Log> f, [Optional] Action<HMMPDCQBBAL, Log> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8306A30", Offset = "0x8305430", VA = "0x188306A30")]
		private static Action<StackTimer<string>, Log> ZLWQJUJROUL(Action<HMMPDCQBBAL, Log> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class XHDFKFMRCEP
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private class CEMKLLIIYYM : XHDFKFMRCEP
		{
			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static XHDFKFMRCEP GUPHEVFTUDK
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x8306680", Offset = "0x8305080", VA = "0x188306680")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override float QRAIJYHXFEF
			{
				[Cpp2IlInjected.Token(Token = "0x6000138")]
				[Cpp2IlInjected.Address(RVA = "0x113E890", Offset = "0x113D290", VA = "0x18113E890", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8306770", Offset = "0x8305170", VA = "0x188306770")]
			public CEMKLLIIYYM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static XHDFKFMRCEP ZTUWATMDIMY;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static XHDFKFMRCEP WUXFTMOSJKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x830B220", Offset = "0x8309C20", VA = "0x18830B220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract float QRAIJYHXFEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected XHDFKFMRCEP()
		{
		}
	}
}
namespace RecRoom.DataStructures.ResourceHandles
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface BRTZTUAOXLG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface TNVOTOCMHUP<a> : BRTZTUAOXLG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[NotNull]
		Task<a> FUHQMVGZKLI
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[NotNull]
		PVOPFDWRLHK<a> MYANCOPWEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class LFGCGIWPUGQ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x375F860", Offset = "0x375E260", VA = "0x18375F860")]
		public static TNVOTOCMHUP<TResource> YAMVHSMKNEV<TResource, a>(this FXTNJHLHQWO<a, TResource> a, a b, [Optional] Func<a, CancellationToken, Task<TResource>>? resourceFactory) where TResource : notnull where a : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class XYNZYSSQXYF
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class EXATJUQODZH<a> : ASVCECIWYWT<a?> where a : class
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override Task<a?> FUHQMVGZKLI
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override PVOPFDWRLHK<a?> MYANCOPWEKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x46ECB10", Offset = "0x46EB510", VA = "0x1846ECB10")]
			public EXATJUQODZH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "10")]
			protected override void JMHETBWRAFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class XWDVGGHWBLN<a> : ASVCECIWYWT<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private readonly a BQADCOZMKQA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private readonly Action<a>? DDFZAGHCIBE;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public override Task<a> FUHQMVGZKLI
			{
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override PVOPFDWRLHK<a> MYANCOPWEKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8F10", Offset = "0x3DF7910", VA = "0x183DF8F10")]
			public XWDVGGHWBLN(a a, Action<a>? onDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3DF8A20", Offset = "0x3DF7420", VA = "0x183DF8A20", Slot = "10")]
			protected override void JMHETBWRAFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class BZFISHSVYBH<a> : ASVCECIWYWT<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override Task<a> FUHQMVGZKLI
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override PVOPFDWRLHK<a> MYANCOPWEKI
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x70E8720", Offset = "0x70E7120", VA = "0x1870E8720")]
			public BZFISHSVYBH(Exception a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "10")]
			protected override void JMHETBWRAFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class NUVUEVLBWXB<a> : ASVCECIWYWT<a> where a : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private struct <<-ctor>g__Unwrap|7_0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public AsyncTaskMethodBuilder<a> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Task<TNVOTOCMHUP<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				private TaskAwaiter<TNVOTOCMHUP<a>> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				private TaskAwaiter<a> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x3CBCF10", Offset = "0x3CBB910", VA = "0x183CBCF10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x3CBDFB0", Offset = "0x3CBC9B0", VA = "0x183CBDFB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private struct <<OnDispose>g__AwaitThenDispose|8_0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public Task<TNVOTOCMHUP<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				private TaskAwaiter<TNVOTOCMHUP<a>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x3CC0C20", Offset = "0x3CBF620", VA = "0x183CC0C20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x3CC0EE0", Offset = "0x3CBF8E0", VA = "0x183CC0EE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private readonly Task<TNVOTOCMHUP<a>> MUFQKCYBAQZ;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override Task<a> FUHQMVGZKLI
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override PVOPFDWRLHK<a> MYANCOPWEKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5907EB0", Offset = "0x59068B0", VA = "0x185907EB0")]
			public NUVUEVLBWXB(Task<TNVOTOCMHUP<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5907510", Offset = "0x5905F10", VA = "0x185907510", Slot = "10")]
			protected override void JMHETBWRAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x5907A80", Offset = "0x5906480", VA = "0x185907A80")]
			[AsyncStateMachine(typeof(NUVUEVLBWXB<>.<<-ctor>g__Unwrap|7_0>d))]
			[CompilerGenerated]
			internal static Task<a> WAHETCBGDNV(Task<TNVOTOCMHUP<a>> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x5907790", Offset = "0x5906190", VA = "0x185907790")]
			[AsyncStateMachine(typeof(NUVUEVLBWXB<>.<<OnDispose>g__AwaitThenDispose|8_0>d))]
			[CompilerGenerated]
			internal static Task VPZXXLVJAAJ(Task<TNVOTOCMHUP<a>> a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private sealed class TMRLXKPEEOF<a, b> : ASVCECIWYWT<b> where a : notnull where b : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private struct <<-ctor>g__Transform|7_0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public AsyncTaskMethodBuilder<b> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public Func<a, b> transformFunc;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public Task<a> innerTask;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				private Func<a, b> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				private TaskAwaiter<a> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x3CBCA80", Offset = "0x3CBB480", VA = "0x183CBCA80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x3CBCE70", Offset = "0x3CBB870", VA = "0x183CBCE70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly TNVOTOCMHUP<a> XMVOLGXEPCK;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override Task<b> FUHQMVGZKLI
			{
				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override PVOPFDWRLHK<b> MYANCOPWEKI
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x5FF02F0", Offset = "0x5FEECF0", VA = "0x185FF02F0")]
			public TMRLXKPEEOF(TNVOTOCMHUP<a> a, Func<a, b> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x5FF02A0", Offset = "0x5FEECA0", VA = "0x185FF02A0", Slot = "10")]
			protected override void JMHETBWRAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x5FF00E0", Offset = "0x5FEEAE0", VA = "0x185FF00E0")]
			[AsyncStateMachine(typeof(TMRLXKPEEOF<, >.<<-ctor>g__Transform|7_0>d))]
			[CompilerGenerated]
			internal static Task<b> GWSLXLVQYUE(Task<a> a, Func<a, b> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9E00", Offset = "0x3BF8800", VA = "0x183BF9E00")]
		public static TNVOTOCMHUP<T> Empty<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA060", Offset = "0x3BF8A60", VA = "0x183BFA060")]
		public static TNVOTOCMHUP<T> WSHKXMEYILY<T>(T a, [Optional] Action<T>? onDispose) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9CB0", Offset = "0x3BF86B0", VA = "0x183BF9CB0")]
		public static TNVOTOCMHUP<T> CPHQUFPFBBC<T>(Exception a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9D20", Offset = "0x3BF8720", VA = "0x183BF9D20")]
		public static TNVOTOCMHUP<T> EYHHNUXRJSW<T>(Task<TNVOTOCMHUP<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9EE0", Offset = "0x3BF88E0", VA = "0x183BF9EE0")]
		public static TNVOTOCMHUP<TOut> Transform<TOut, TIn>(TNVOTOCMHUP<TIn> handle, Func<TIn, TOut> transformFunc) where TOut : notnull where TIn : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public abstract class ASVCECIWYWT<a> : TNVOTOCMHUP<a>, BRTZTUAOXLG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static readonly string JXJYFGPNDDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly DisposeReminder MYJFONFBXFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private bool IWZTIHAPXBS;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xB50300", Offset = "0xB4ED00", VA = "0x180B50300", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract Task<a> FUHQMVGZKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public abstract PVOPFDWRLHK<a> MYANCOPWEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5551530", Offset = "0x554FF30", VA = "0x185551530")]
		public ASVCECIWYWT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5551130", Offset = "0x554FB30", VA = "0x185551130", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void JMHETBWRAFN();
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class ATAJBJCUIIC<a, b> : ASVCECIWYWT<b> where a : Task
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class CDBDDHGPLTW
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public AsyncTaskMethodBuilder<b> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public a originalTask;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public CDBDDHGPLTW <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x3CBC040", Offset = "0x3CBAA40", VA = "0x183CBC040", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x3CBC3E0", Offset = "0x3CBADE0", VA = "0x183CBC3E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public ATAJBJCUIIC<a, b> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public CancellationToken BSVVXCOCAGW;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CDBDDHGPLTW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3D4B3C0", Offset = "0x3D49DC0", VA = "0x183D4B3C0")]
			[AsyncStateMachine(typeof(ATAJBJCUIIC<, >.CDBDDHGPLTW.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
			internal Task<b> ZKJBBFQQHRX(a a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Task<b> XBJDPZXBWSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		protected readonly CancellationTokenSource LSWXXGKKWFO;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override Task<b> FUHQMVGZKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override PVOPFDWRLHK<b> MYANCOPWEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5551840", Offset = "0x5550240", VA = "0x185551840")]
		protected ATAJBJCUIIC(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x55515D0", Offset = "0x554FFD0", VA = "0x1855515D0", Slot = "10")]
		protected override void JMHETBWRAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract b JUWLZWAUYFT(a a);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void PBTIRVZZULO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class PBZYCHGRLAV<a> : ASVCECIWYWT<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly OLMGUJGMNOB<Task<a>> TVVJVURGEOP;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public override Task<a> FUHQMVGZKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xCE2260", Offset = "0xCE0C60", VA = "0x180CE2260", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override PVOPFDWRLHK<a> MYANCOPWEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5B8BEB0", Offset = "0x5B8A8B0", VA = "0x185B8BEB0")]
		public PBZYCHGRLAV(OLMGUJGMNOB<Task<a>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x5B8BE90", Offset = "0x5B8A890", VA = "0x185B8BE90", Slot = "10")]
		protected override void JMHETBWRAFN()
		{
		}
	}
}
namespace RecRoom.DataStructures.Hashing
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class OCRKWIBQMRF
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly HashAlgorithmName ZOFQMLDMTQL;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly ThreadLocal<IncrementalHash> JYUSBMCEESO;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8308A40", Offset = "0x8307440", VA = "0x188308A40")]
		public static int OLIVZQHPOEU(this GKXLWMDZWGG a, IncrementalHash b, byte[] c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x83083D0", Offset = "0x8306DD0", VA = "0x1883083D0")]
		public static bool ERZULLLAHPH([CanBeNull] this GKXLWMDZWGG hashableAsset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8308430", Offset = "0x8306E30", VA = "0x188308430")]
		public static bool ERZULLLAHPH([CanBeNull] this GKXLWMDZWGG hashableAsset, [Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8308730", Offset = "0x8307130", VA = "0x188308730")]
		public static bool ERZULLLAHPH([CanBeNull] this GKXLWMDZWGG hashableAsset, IncrementalHash a, byte[] b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8308AD0", Offset = "0x83074D0", VA = "0x188308AD0")]
		private static bool QQCMWCQBSPT(byte[] a, Span<byte> b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class TGTETQFAVUF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x830A690", Offset = "0x8309090", VA = "0x18830A690")]
		public static int EWWBPJJLYIK(HashAlgorithmName a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3A80850", Offset = "0x3A7F250", VA = "0x183A80850")]
		public static int OLIVZQHPOEU<a>(this a a, byte[] b, IncrementalHash c, byte[] d) where a : PSVWBXAFMWS
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface PSVWBXAFMWS
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AppendToHash([NotNull] IncrementalHash hash);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface GKXLWMDZWGG : PSVWBXAFMWS
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[CanBeNull]
		byte[] KUCRTEFHMMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[CanBeNull]
		byte[] DLZBFDWXFNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class NETALHZQIBF
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static bool EKVQOWNTVTZ;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly ArrayPool<byte> BKBJNCYOJXM;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly ArrayPool<char> NFTDYHZMVPE;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly Encoding WWAIFWABWTL;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ThreadLocal<Encoder> MLORBZKANBG;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x38631E0", Offset = "0x3861BE0", VA = "0x1838631E0")]
		public static void GZUZFZFIDQR<b>(this IncrementalHash a, [CanBeNull] b component) where b : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3863150", Offset = "0x3861B50", VA = "0x183863150")]
		public static void BGTSCQDSAGD<c>(this IncrementalHash a, [CanBeNull] c hashable) where c : PSVWBXAFMWS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3864730", Offset = "0x3863130", VA = "0x183864730")]
		public static void QVWUGHCLWLW<d>(this IncrementalHash a, [CanBeNull] IList<d> hashablesList) where d : PSVWBXAFMWS
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x83073A0", Offset = "0x8305DA0", VA = "0x1883073A0")]
		private static bool BSHIQPEUQKS([CanBeNull] PSVWBXAFMWS hashable)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x83079B0", Offset = "0x83063B0", VA = "0x1883079B0")]
		public static void VXJPXNBPZZQ(this IncrementalHash a, string? stringValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8307D90", Offset = "0x8306790", VA = "0x188307D90")]
		public static void WABJBGGZNDT(this IncrementalHash a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8307560", Offset = "0x8305F60", VA = "0x188307560")]
		public static void HESJQZWGHZW(this IncrementalHash a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x83076D0", Offset = "0x83060D0", VA = "0x1883076D0")]
		public static void LQTVTMTOFLB(this IncrementalHash a, short b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x83078A0", Offset = "0x83062A0", VA = "0x1883078A0")]
		public static void NYUPBNXFAUB(this IncrementalHash a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8307230", Offset = "0x8305C30", VA = "0x188307230")]
		public static void BHJAOOUIBEA(this IncrementalHash a, bool b, bool c = false, bool d = false, bool e = false, bool f = false, bool g = false, bool h = false, bool i = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x38632A0", Offset = "0x3861CA0", VA = "0x1838632A0")]
		public static void KNBXZVUBAIC<e>(this IncrementalHash a, e b) where e : struct, Enum, IConvertible
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8307840", Offset = "0x8306240", VA = "0x188307840")]
		public static void NSBZBCRQBKP(this IncrementalHash a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8307F60", Offset = "0x8306960", VA = "0x188307F60")]
		public static void XYWPZLXAXRG(this IncrementalHash a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8307FC0", Offset = "0x83069C0", VA = "0x188307FC0")]
		public static void ZVGLLBXFOWP(this IncrementalHash a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8307F00", Offset = "0x8306900", VA = "0x188307F00")]
		public static void XWDPRHSCPJO(this IncrementalHash a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8307430", Offset = "0x8305E30", VA = "0x188307430")]
		public static void GKAYWSKSQJP(this IncrementalHash a, Vector3 b)
		{
		}
	}
}
namespace RecRoom.DataStructures.Exceptions
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DataDesyncException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8306950", Offset = "0x8305350", VA = "0x188306950")]
		public DataDesyncException(string message)
		{
		}
	}
}
namespace RecRoom.Core.Scripts.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class ZYNTRLAPOVB
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate void OnStateChange(ushort currentStateId, ushort previousStateId, ushort currentSubStateId, ushort previousSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate void StateTransition(ushort otherStateId, ushort otherSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public delegate void StateUpdate();

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public const ushort ZYEGNITSBAM = 65535;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected ZYNTRLAPOVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class COLJBKPDTTG<a> : ZYNTRLAPOVB where a : COLJBKPDTTG<a>.KKMMBJOMBGT
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public interface KKMMBJOMBGT
		{
			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			StateTransition MIKXAOVBFEE
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			StateTransition NELYVAWWPMS
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			StateUpdate OEHTWLTCNXN
			{
				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<uint, a> PJHZAROQCHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private StateUpdate GVFETJLJGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private StateUpdate ZYKJWGREHSC;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool UWZYWXOVDPT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xAB99A0", Offset = "0xAB83A0", VA = "0x180AB99A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ushort SWONXDTGGRC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xFECDD0", Offset = "0xFEB7D0", VA = "0x180FECDD0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xFECDC0", Offset = "0xFEB7C0", VA = "0x180FECDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public ushort ACWRDMNYNVY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3D7B430", Offset = "0x3D79E30", VA = "0x183D7B430")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3D7D1F0", Offset = "0x3D7BBF0", VA = "0x183D7D1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public ushort DZPOHNQBDDE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xCAF6C0", Offset = "0xCAE0C0", VA = "0x180CAF6C0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xCAF840", Offset = "0xCAE240", VA = "0x180CAF840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ushort LNDYHTYULOU
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3D7C8A0", Offset = "0x3D7B2A0", VA = "0x183D7C8A0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3D7C8B0", Offset = "0x3D7B2B0", VA = "0x183D7C8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected bool EALASSPAXDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xFECBD0", Offset = "0xFEB5D0", VA = "0x180FECBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected bool UTUDMQTEAFS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1823A10", Offset = "0x1822410", VA = "0x181823A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OnStateChange OHCCXFKXKFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x3D7CB10", Offset = "0x3D7B510", VA = "0x183D7CB10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3D7B2F0", Offset = "0x3D79CF0", VA = "0x183D7B2F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CFB0", Offset = "0x3D7B9B0", VA = "0x183D7CFB0")]
		private a RYHPJQRESAJ(ushort a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D020", Offset = "0x3D7BA20", VA = "0x183D7D020")]
		private a TEQETYCQFGO(ushort a, ushort b)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CBB0", Offset = "0x3D7B5B0", VA = "0x183D7CBB0")]
		protected a PGMURSNULWU(uint a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D5E0", Offset = "0x3D7BFE0", VA = "0x183D7D5E0")]
		protected COLJBKPDTTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CA50", Offset = "0x3D7B450", VA = "0x183D7CA50")]
		public void NPMWEUTUZIE(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C8F0", Offset = "0x3D7B2F0", VA = "0x183D7C8F0")]
		public void NPMWEUTUZIE(ushort a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C8C0", Offset = "0x3D7B2C0", VA = "0x183D7C8C0", Slot = "4")]
		protected virtual void NPMWEUTUZIE(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B5E0", Offset = "0x3D79FE0", VA = "0x183D7B5E0")]
		protected void JFIAYHCOWKC(uint a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B440", Offset = "0x3D79E40", VA = "0x183D7B440")]
		protected void FYCQACLHXNE(ushort a, ushort b, a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D7CD10", Offset = "0x3D7B710", VA = "0x183D7CD10")]
		private void ROGAJLFUOGE(uint a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D450", Offset = "0x3D7BE50", VA = "0x183D7D450")]
		protected void TXXXZERLHEI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D010", Offset = "0x3D7BA10", VA = "0x183D7D010")]
		protected uint SERZPMISYJH(ushort a, ushort b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D5D0", Offset = "0x3D7BFD0", VA = "0x183D7D5D0")]
		protected ushort ZMRNYMQPNHJ(uint a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D7C890", Offset = "0x3D7B290", VA = "0x183D7C890")]
		protected ushort KOODRLQKGAA(uint a)
		{
			return default(ushort);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class KPISLMSATPK : COLJBKPDTTG<KPISLMSATPK.State>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class State : KKMMBJOMBGT
		{
			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public StateTransition MIKXAOVBFEE
			{
				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public StateTransition NELYVAWWPMS
			{
				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public StateUpdate OEHTWLTCNXN
			{
				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public State()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8306F10", Offset = "0x8305910", VA = "0x188306F10")]
		public void QMMQRXIACFB(ushort a, StateTransition b, StateTransition c, StateUpdate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8306FF0", Offset = "0x83059F0", VA = "0x188306FF0")]
		public void QMMQRXIACFB(ushort a, ushort b, StateTransition c, StateTransition d, StateUpdate e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x83070D0", Offset = "0x8305AD0", VA = "0x1883070D0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8307120", Offset = "0x8305B20", VA = "0x188307120")]
		protected KPISLMSATPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class NQPRPAKLGMK : KPISLMSATPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool QESNNZNLTIO;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool BXPTSGXIQZR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xCB3680", Offset = "0xCB2080", VA = "0x180CB3680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xCB3480", Offset = "0xCB1E80", VA = "0x180CB3480")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x83082F0", Offset = "0x8306CF0", VA = "0x1883082F0")]
		public void Initialize(ushort initialStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8308290", Offset = "0x8306C90", VA = "0x188308290")]
		public void Initialize(ushort initialStateId, ushort initialSubStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8307120", Offset = "0x8305B20", VA = "0x188307120")]
		public NQPRPAKLGMK()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class KJAIWXGDJAF<a, b> : IDisposable where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal class JBODZLNJVRF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public b TIAELBBEYLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public b HJMDDSQJNLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public PriorityClaim IAKYPZPNSRM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public List<PriorityClaim> VQSCWFTLIEX;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public JBODZLNJVRF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		internal struct PriorityClaim : IComparable<PriorityClaim>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public int priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public a claim;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x16C88D0", Offset = "0x16C72D0", VA = "0x1816C88D0")]
			public PriorityClaim(int priority, a claim)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x5C0DEB0", Offset = "0x5C0C8B0", VA = "0x185C0DEB0")]
			public bool UGPJSFFNORS([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x5C0DE40", Offset = "0x5C0C840", VA = "0x185C0DE40")]
			public bool QISVYHVILRV([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x5C0DE30", Offset = "0x5C0C830", VA = "0x185C0DE30", Slot = "4")]
			public int CompareTo(PriorityClaim other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x5C0DE50", Offset = "0x5C0C850", VA = "0x185C0DE50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			FirstOwner,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			ClosestAncestor
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class OKBLORBQFBB : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private b YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private b PPYDDFXDHTW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public b OZWEAVJTXOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public KJAIWXGDJAF<a, b> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private b DBYSBJSFHNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public b UKPGJEEQTNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private bool KJJVSXCOFYY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public bool FPJMTZFHOTT;

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			private b OERZBPNSODA
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
			[DebuggerHidden]
			public OKBLORBQFBB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x5AB3BC0", Offset = "0x5AB25C0", VA = "0x185AB3BC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A650", Offset = "0x3D49050", VA = "0x183D4A650", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x5AB3AE0", Offset = "0x5AB24E0", VA = "0x185AB3AE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> FYEBMOBNFSF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x5AB3CA0", Offset = "0x5AB26A0", VA = "0x185AB3CA0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly ACZOEWEQFFG<JBODZLNJVRF> MJMUOZGTDSR;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly ACZOEWEQFFG<List<PriorityClaim>> QLBRWEHBAYR;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static int KHBQEGTHDRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		internal readonly Dictionary<a, b> BWTTYNMGUNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		internal readonly Dictionary<b, JBODZLNJVRF> JTJDGZDENZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mode RRLTBPJVRCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool VACBKMVGOGA;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract b HOPHQKDCWUF(b a);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void IQBEQSPZAUR(b a, a b, a c);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5293CD0", Offset = "0x52926D0", VA = "0x185293CD0")]
		public KJAIWXGDJAF(Mode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x52927C0", Offset = "0x52911C0", VA = "0x1852927C0")]
		public void JHJMQFSNJBY(b a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5292600", Offset = "0x5291000", VA = "0x185292600")]
		public void EXYTJOGKRHW(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5292440", Offset = "0x5290E40", VA = "0x185292440", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x52929F0", Offset = "0x52913F0", VA = "0x1852929F0")]
		private void SVRPYUVWCXT(a a, b b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5292760", Offset = "0x5291160", VA = "0x185292760")]
		private int IDZJWZOAQRR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5293220", Offset = "0x5291C20", VA = "0x185293220")]
		private void VVMTLHKAXPQ(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5293930", Offset = "0x5292330", VA = "0x185293930")]
		private void XGLFYXEFGRF(PriorityClaim a, JBODZLNJVRF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5292F20", Offset = "0x5291920", VA = "0x185292F20")]
		private void VFPSTOTOMFK(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5292A90", Offset = "0x5291490", VA = "0x185292A90")]
		private void SVSLVGSAIOF(PriorityClaim a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5292840", Offset = "0x5291240", VA = "0x185292840")]
		private void LLWTPWDIYXL(PriorityClaim a, JBODZLNJVRF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5292E10", Offset = "0x5291810", VA = "0x185292E10")]
		private void UGEQMXSGMGY(JBODZLNJVRF a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5293610", Offset = "0x5292010", VA = "0x185293610")]
		private void WOHHEHGRGZA(JBODZLNJVRF a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5292910", Offset = "0x5291310", VA = "0x185292910")]
		[IteratorStateMachine(typeof(KJAIWXGDJAF<, >.OKBLORBQFBB))]
		private IEnumerable<b> PGXLQMUCBWI(b a, b b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5292280", Offset = "0x5290C80", VA = "0x185292280")]
		private JBODZLNJVRF BNHMIWEOWHO(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5293A20", Offset = "0x5292420", VA = "0x185293A20")]
		private JBODZLNJVRF ZWUYASKKNIH(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5292110", Offset = "0x5290B10", VA = "0x185292110")]
		private void BKJAUWOJYHF(JBODZLNJVRF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class OUZJHNVVKXT<a> : IEnumerable<OUZJHNVVKXT<a>.Pair>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public struct Pair
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public a value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public int index;
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public class ETEKRSSDCEV : IEnumerator<Pair>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private OUZJHNVVKXT<a> DTUDOWZGJJV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private int SPLEGEZJYLT;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x46D2560", Offset = "0x46D0F60", VA = "0x1846D2560", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x46D2910", Offset = "0x46D1310", VA = "0x1846D2910", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x46D25D0", Offset = "0x46D0FD0", VA = "0x1846D25D0")]
			public ETEKRSSDCEV(OUZJHNVVKXT<a> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x46D2340", Offset = "0x46D0D40", VA = "0x1846D2340", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x46D25C0", Offset = "0x46D0FC0", VA = "0x1846D25C0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xCB03D0", Offset = "0xCAEDD0", VA = "0x180CB03D0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private struct ListEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public bool hasValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public a value;
		}

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private const int JIUWHZHSOAF = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly Dictionary<a, int> UODEZOZTYWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ListEntry[] VLPFFLHLMUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int NYGWCXDIOSU;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int HSZGXSSVBZN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x5AC8100", Offset = "0x5AC6B00", VA = "0x185AC8100")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9210", Offset = "0x5AC7C10", VA = "0x185AC9210")]
		public OUZJHNVVKXT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8220", Offset = "0x5AC6C20", VA = "0x185AC8220")]
		public OUZJHNVVKXT(Pair[] a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8160", Offset = "0x5AC6B60", VA = "0x185AC8160")]
		public int YKVZIASUZCW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5AC7C10", Offset = "0x5AC6610", VA = "0x185AC7C10")]
		private int SFAZSDMTVCV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5AC7730", Offset = "0x5AC6130", VA = "0x185AC7730", Slot = "6")]
		protected virtual uint PLWVMSTNVGV(uint a, a b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6540", Offset = "0x5AC4F40", VA = "0x185AC6540")]
		public bool BLFUKHQBWQD(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6830", Offset = "0x5AC5230", VA = "0x185AC6830")]
		public int CESHKLYXYMT(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6BB0", Offset = "0x5AC55B0", VA = "0x185AC6BB0")]
		public a EZPQDIKHPRU(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5AC7140", Offset = "0x5AC5B40", VA = "0x185AC7140")]
		public bool MMKMTAKCVDN(a a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5AC74F0", Offset = "0x5AC5EF0", VA = "0x185AC74F0")]
		public bool MMKMTAKCVDN(a a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6980", Offset = "0x5AC5380", VA = "0x185AC6980")]
		private int CSSFYNZIIXY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8000", Offset = "0x5AC6A00", VA = "0x185AC8000", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8000", Offset = "0x5AC6A00", VA = "0x185AC8000", Slot = "4")]
		private IEnumerator<Pair> UALEWQCGHAM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ACZOEWEQFFG<a> : IDisposable where a : new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Stack<a> ULAPHSUBTVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<a> RCJFYTMUUVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly int SYWVWMKJEDC;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x53F65E0", Offset = "0x53F4FE0", VA = "0x1853F65E0")]
		public static ACZOEWEQFFG<a> TEIJGGJQMAK(int a = 0, int b = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x53F6CE0", Offset = "0x53F56E0", VA = "0x1853F6CE0")]
		public ACZOEWEQFFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x53F6D10", Offset = "0x53F5710", VA = "0x1853F6D10")]
		public ACZOEWEQFFG(int a, int b = 2147483647, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x53F5AF0", Offset = "0x53F44F0", VA = "0x1853F5AF0")]
		public a Acquire()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x53F6220", Offset = "0x53F4C20", VA = "0x1853F6220")]
		public void Release(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x53F5EC0", Offset = "0x53F48C0", VA = "0x1853F5EC0")]
		private void HFRGKDAZIGL(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x53F6200", Offset = "0x53F4C00", VA = "0x1853F6200")]
		private void KYUWGCUOTSY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x53F5DA0", Offset = "0x53F47A0", VA = "0x1853F5DA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x53F68E0", Offset = "0x53F52E0", VA = "0x1853F68E0")]
		private void XDRJJSBTQBL(IEnumerable<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class WUSUPEYJCZG<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private Dictionary<int, a> JPNUUMQDIDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private a ZQEFHEWMDRL;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual a LOFXOEVRQZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x1140D50", Offset = "0x113F750", VA = "0x181140D50", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x671DE10", Offset = "0x671C810", VA = "0x18671DE10")]
		public bool YPICJLEXZNJ(a a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x671D4B0", Offset = "0x671BEB0", VA = "0x18671D4B0")]
		public bool PAIKSWXLMCI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x671D8A0", Offset = "0x671C2A0", VA = "0x18671D8A0")]
		public a VWQGTWTTHJA(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x671D510", Offset = "0x671BF10", VA = "0x18671D510")]
		private bool QGITHKLRRCW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x671D320", Offset = "0x671BD20", VA = "0x18671D320")]
		public bool CIWAHGAOAZX(int a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x671E090", Offset = "0x671CA90", VA = "0x18671E090")]
		public WUSUPEYJCZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class CUMERFEWXJH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		protected struct Entry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public a Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public int Priority;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		protected readonly List<Entry> KAEWAGQSVZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private a UKMMDGVZPNM;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2519530", Offset = "0x2517F30", VA = "0x182519530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4D90", Offset = "0x3DA3790", VA = "0x183DA4D90")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4640", Offset = "0x3DA3040", VA = "0x183DA4640")]
		public void Add(a value, int priority)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3DA5AC0", Offset = "0x3DA44C0", VA = "0x183DA5AC0")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4A30", Offset = "0x3DA3430", VA = "0x183DA4A30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3DA53F0", Offset = "0x3DA3DF0", VA = "0x183DA53F0")]
		public a IZHKSYRBXLG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3DA5BB0", Offset = "0x3DA45B0", VA = "0x183DA5BB0")]
		protected void SQUBLROGLUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6440", Offset = "0x3DA4E40", VA = "0x183DA6440")]
		public CUMERFEWXJH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x8308FA0", Offset = "0x83079A0", VA = "0x188308FA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x8309270", Offset = "0x8307C70", VA = "0x188309270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x8309180", Offset = "0x8307B80", VA = "0x188309180")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8308EF0", Offset = "0x83078F0", VA = "0x188308EF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x83091C0", Offset = "0x8307BC0", VA = "0x1883091C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x83090D0", Offset = "0x8307AD0", VA = "0x1883090D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8308E70", Offset = "0x8307870", VA = "0x188308E70")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5E96880", Offset = "0x5E95280", VA = "0x185E96880", Slot = "4")]
		public virtual T LSTXIRLCMKZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected ResourcePrefabReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public interface EKDHUBTRBYD
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		ToolHierarchyCache HBEVYEAHJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public struct Enumerable<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool includeInactive;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1836260", Offset = "0x1834C60", VA = "0x181836260")]
			public Enumerable(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x470BC30", Offset = "0x470A630", VA = "0x18470BC30")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x470BF00", Offset = "0x470A900", VA = "0x18470BF00", Slot = "5")]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x470BF00", Offset = "0x470A900", VA = "0x18470BF00", Slot = "4")]
			private IEnumerator<T> XHEIENLLPFX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public struct Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool includeInactive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public T Current
			{
				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x47C0900", Offset = "0x47BF300", VA = "0x1847C0900", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x47BFC80", Offset = "0x47BE680", VA = "0x1847BFC80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x47C0580", Offset = "0x47BEF80", VA = "0x1847C0580")]
			public Enumerator(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x47BF0E0", Offset = "0x47BDAE0", VA = "0x1847BF0E0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x47BFB80", Offset = "0x47BE580", VA = "0x1847BFB80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x470DBC0", Offset = "0x470C5C0", VA = "0x18470DBC0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> VYINCXSSTAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Dictionary<Type, List<Component>> VYNNUUABHIY;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x830AEC0", Offset = "0x83098C0", VA = "0x18830AEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x830ACD0", Offset = "0x83096D0", VA = "0x18830ACD0")]
		private void Initialize(GameObject go, bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x830AC40", Offset = "0x8309640", VA = "0x18830AC40")]
		public static void Initialize(GameObject go, ToolHierarchyCache cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x830AE30", Offset = "0x8309830", VA = "0x18830AE30")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3A97DE0", Offset = "0x3A967E0", VA = "0x183A97DE0")]
		public void NJNGLYKSSGX<a>(Action<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3A97FA0", Offset = "0x3A969A0", VA = "0x183A97FA0")]
		public b WKHWTNNNNLG<b>(bool a = false) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3A97A60", Offset = "0x3A96460", VA = "0x183A97A60")]
		public Enumerable<c> LBQXJOYZZEJ<c>(bool a = false) where c : class
		{
			return default(Enumerable<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x830A860", Offset = "0x8309260", VA = "0x18830A860")]
		public List<Component> GYJGQWNJCSM(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x830A7E0", Offset = "0x83091E0", VA = "0x18830A7E0", Slot = "4")]
		public bool Equals(ToolHierarchyCache x, ToolHierarchyCache y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x830ABD0", Offset = "0x83095D0", VA = "0x18830ABD0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache obj)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class TRPQOPCEPXD<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private int NEKWUZIRPDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int KXQXXTNJXNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private List<a> ZEXLFFITBGK;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int QYQDPJWWJPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x24ABCA0", Offset = "0x24AA6A0", VA = "0x1824ABCA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public a NQNUEHVSNFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x5FF3BD0", Offset = "0x5FF25D0", VA = "0x185FF3BD0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public a MOGQSUERRHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x5FF3A00", Offset = "0x5FF2400", VA = "0x185FF3A00")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public a IHTRAXPOLUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x5FF3FA0", Offset = "0x5FF29A0", VA = "0x185FF3FA0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4060", Offset = "0x5FF2A60", VA = "0x185FF4060")]
		public TRPQOPCEPXD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3190", Offset = "0x5FF1B90", VA = "0x185FF3190")]
		public void Add(a command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5FF37B0", Offset = "0x5FF21B0", VA = "0x185FF37B0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5FF35B0", Offset = "0x5FF1FB0", VA = "0x185FF35B0")]
		public void BLUCSVFQTDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3850", Offset = "0x5FF2250", VA = "0x185FF3850")]
		public void JBKWEBQUDTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5FF37E0", Offset = "0x5FF21E0", VA = "0x185FF37E0")]
		public void HNWIBWLJEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3A80", Offset = "0x5FF2480", VA = "0x185FF3A80")]
		public List<a> JOXFQMMZZZU()
		{
			return null;
		}
	}
}
namespace RecRoom.Core.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class QRRCQEKUKQZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private struct PrioritizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public int Priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public a Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly Dictionary<object, PrioritizedData> JPNUUMQDIDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly EqualityComparer<a> ZTGLMMGQGYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private a ZQEFHEWMDRL;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual a LOFXOEVRQZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xC02990", Offset = "0xC01390", VA = "0x180C02990", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x5C4F5C0", Offset = "0x5C4DFC0", VA = "0x185C4F5C0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool RSGJDQOVFEM
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x5C4F8E0", Offset = "0x5C4E2E0", VA = "0x185C4F8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public object CLKNRIVQHWS
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F920", Offset = "0x5C4E320", VA = "0x185C4F920")]
		public bool YPICJLEXZNJ(a a, object b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F5E0", Offset = "0x5C4DFE0", VA = "0x185C4F5E0")]
		public bool PAIKSWXLMCI(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F520", Offset = "0x5C4DF20", VA = "0x185C4F520")]
		public bool CIWAHGAOAZX(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F590", Offset = "0x5C4DF90", VA = "0x185C4F590")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F650", Offset = "0x5C4E050", VA = "0x185C4F650")]
		private bool QGITHKLRRCW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F9D0", Offset = "0x5C4E3D0", VA = "0x185C4F9D0")]
		public QRRCQEKUKQZ()
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
