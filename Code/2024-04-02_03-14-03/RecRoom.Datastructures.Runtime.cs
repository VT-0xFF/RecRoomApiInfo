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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x60FA8A0", Offset = "0x60F94A0", VA = "0x1860FA8A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AHNDEJANFKO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C0100", Offset = "0x7BED00", VA = "0x1807C0100")]
	public AHNDEJANFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, HNCKGPAFGOJ, BGDIIHANLOF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B30", Offset = "0x7B1730", VA = "0x1807B2B30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash HCLBLKKJPDE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x89ACE0", Offset = "0x8998E0", VA = "0x18089ACE0")]
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
	[MIGNAGNMKHF]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[HideInInspector]
	[MIGNAGNMKHF]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60FC780", Offset = "0x60FB380", VA = "0x1860FC780")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60FC740", Offset = "0x60FB340", VA = "0x1860FC740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x60FC7C0", Offset = "0x60FB3C0", VA = "0x1860FC7C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60FC970", Offset = "0x60FB570", VA = "0x1860FC970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x60FC8E0", Offset = "0x60FB4E0", VA = "0x1860FC8E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x93A5F0", Offset = "0x9391F0", VA = "0x18093A5F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F49F0", Offset = "0x9F35F0", VA = "0x1809F49F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60FC700", Offset = "0x60FB300", VA = "0x1860FC700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60FC850", Offset = "0x60FB450", VA = "0x1860FC850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60FC230", Offset = "0x60FAE30", VA = "0x1860FC230")]
	public void CopyBounds(SavedExtents NAFFCAIMPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60FC650", Offset = "0x60FB250", VA = "0x1860FC650")]
	public void SetLocalSpaceBounds(Bounds DPLDJMECLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA26BC0", Offset = "0xA257C0", VA = "0x180A26BC0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60FC640", Offset = "0x60FB240", VA = "0x1860FC640")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60FC260", Offset = "0x60FAE60", VA = "0x1860FC260")]
	private void FOADPIHEKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60FC420", Offset = "0x60FB020", VA = "0x1860FC420")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60FBBC0", Offset = "0x60FA7C0", VA = "0x1860FBBC0")]
	public static void CalculateLocalBoundsFor(GameObject DNJHAKIPIPL, [Out] Bounds DPLDJMECLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60FBB00", Offset = "0x60FA700", VA = "0x1860FBB00")]
	private static void BGFPMBGJMJA(Bounds ECIMPLOCMKE, Color IELECLNDABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60FC670", Offset = "0x60FB270", VA = "0x1860FC670")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AF180", Offset = "0x7ADD80", VA = "0x1807AF180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B9610", Offset = "0x7B8210", VA = "0x1807B9610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE5DC00", Offset = "0xE5C800", VA = "0x180E5DC00")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x42E6850", Offset = "0x42E5450", VA = "0x1842E6850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
	public virtual void IGCBEEKHMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
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
	[AHNDEJANFKO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42E6430", Offset = "0x42E5030", VA = "0x1842E6430", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x42E50D0", Offset = "0x42E3CD0", VA = "0x1842E50D0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42E6780", Offset = "0x42E5380", VA = "0x1842E6780")]
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
	private sealed class EDFOLMOLGGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public EDFOLMOLGGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3307020", Offset = "0x3305C20", VA = "0x183307020")]
		internal int AHNAGLIIBNM(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[AHNDEJANFKO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3354C00", Offset = "0x3353800", VA = "0x183354C00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3354C50", Offset = "0x3353850", VA = "0x183354C50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3354B00", Offset = "0x3353700", VA = "0x183354B00", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey CGGNJKGENIH]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3354BA0", Offset = "0x33537A0", VA = "0x183354BA0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x33549E0", Offset = "0x33535E0", VA = "0x1833549E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3354700", Offset = "0x3353300", VA = "0x183354700", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3353BA0", Offset = "0x33527A0", VA = "0x183353BA0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3353A20", Offset = "0x3352620", VA = "0x183353A20", Slot = "14")]
	protected virtual string BAMCOMLIOFM(TKeyVal OONKGLJDGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3353AB0", Offset = "0x33526B0", VA = "0x183353AB0", Slot = "4")]
	public bool ContainsKey(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x33548A0", Offset = "0x33534A0", VA = "0x1833548A0", Slot = "5")]
	public bool TryGetValue(TKey CGGNJKGENIH, [Out] TVal BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3353B00", Offset = "0x3352700", VA = "0x183353B00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3353B00", Offset = "0x3352700", VA = "0x183353B00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x33548F0", Offset = "0x33534F0", VA = "0x1833548F0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DLPJMMGDPAE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class KBAOKJCHPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float DCEPCIGDMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T BLAEOCKJGCA;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public KBAOKJCHPEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KMDADMEHPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public KMDADMEHPMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B78410", Offset = "0x3B77010", VA = "0x183B78410")]
		internal bool CPANAJKEHIK(KBAOKJCHPEM sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float OLONHIAIBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float HHHOLBIJDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<KBAOKJCHPEM> BLLLNCIJEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private GPJPJMEBCMC<KBAOKJCHPEM> DIEOFCOKIFF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int KCKKAPNJGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x505E5E0", Offset = "0x505D1E0", VA = "0x18505E5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x505F190", Offset = "0x505DD90", VA = "0x18505F190")]
	public DLPJMMGDPAE(float OGFDFCBCCED, float MDOOGGGDJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x505EEA0", Offset = "0x505DAA0", VA = "0x18505EEA0")]
	public bool HDDPEIDAINN(float EAKAKFEGLBF, T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x505E650", Offset = "0x505D250", VA = "0x18505E650")]
	public IEnumerable<T> GDKINGAHDJG(float EAKAKFEGLBF, [Optional] float? MPBDNMOMMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x505ECB0", Offset = "0x505D8B0", VA = "0x18505ECB0")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x505F030", Offset = "0x505DC30", VA = "0x18505F030")]
	private void ODIDMMDNBOD(float EAKAKFEGLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class LJBMEHDJFAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct EILCHLDDPIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T BLAEOCKJGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float FNMPHHCELPK;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float NHBDJBLJCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> GLBPBHNHPOK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int KGEKHLMECMN = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private EILCHLDDPIC[] GBCEGNLFFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int EKJLMNEEGKM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float LNLHAJNOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84CB90", Offset = "0x84B790", VA = "0x18084CB90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86C140", Offset = "0x86AD40", VA = "0x18086C140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A770", Offset = "0x3C29370", VA = "0x183C2A770")]
	public LJBMEHDJFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A680", Offset = "0x3C29280", VA = "0x183C2A680")]
	public LJBMEHDJFAI(int JKNAAACFMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3C29860", Offset = "0x3C28460", VA = "0x183C29860")]
	public void BGJHDHHBMPP(float EAKAKFEGLBF, T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A120", Offset = "0x3C28D20", VA = "0x183C2A120")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3C29BA0", Offset = "0x3C287A0", VA = "0x183C29BA0")]
	public bool EBOHAMJDNND(float OCJFHPHIOEO, float GGPPDFCAPJJ, [Out] T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A450", Offset = "0x3C29050", VA = "0x183C2A450")]
	public bool MOECEPEJKLK(float OCJFHPHIOEO, float GGPPDFCAPJJ, [Out] T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3C29EF0", Offset = "0x3C28AF0", VA = "0x183C29EF0")]
	public void FCHGIPMENME(float OCJFHPHIOEO, float GGPPDFCAPJJ, List<T> KLIMJJKAHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A5F0", Offset = "0x3C291F0", VA = "0x183C2A5F0")]
	private int NGDCECPPLAP(int AIKMJJOKGEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A210", Offset = "0x3C28E10", VA = "0x183C2A210")]
	private void HPODKMNBKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DFLCEFKLILH();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T HEOFIFIFCII(T BLKAHBIJBJO, float JIGADAOLAJF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T APDGIBEOLKI(T AHIHMLDOCPC, T APNBCADOPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IBHLAECBOCH(T AHIHMLDOCPC, T APNBCADOPPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JDIGMEFPFHA : LJBMEHDJFAI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0990", Offset = "0x7BF590", VA = "0x1807C0990", Slot = "4")]
	protected override Vector3 DFLCEFKLILH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60FA540", Offset = "0x60F9140", VA = "0x1860FA540", Slot = "5")]
	protected override Vector3 HEOFIFIFCII(Vector3 BLKAHBIJBJO, float JIGADAOLAJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60FA4F0", Offset = "0x60F90F0", VA = "0x1860FA4F0", Slot = "6")]
	protected override Vector3 APDGIBEOLKI(Vector3 AHIHMLDOCPC, Vector3 APNBCADOPPJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60FA580", Offset = "0x60F9180", VA = "0x1860FA580", Slot = "7")]
	protected override Vector3 IBHLAECBOCH(Vector3 AHIHMLDOCPC, Vector3 APNBCADOPPJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60FA600", Offset = "0x60F9200", VA = "0x1860FA600")]
	public JDIGMEFPFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KHPFMINELEH
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28584A0", Offset = "0x28570A0", VA = "0x1828584A0")]
	public static AMCCBMCJLBI<T1, T2> JOBBHNKGDPO<T1, T2>(T1 JMAKBCGCNNC, T2 MDIPGPEINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2858520", Offset = "0x2857120", VA = "0x182858520")]
	public static OGOLCPKHEJJ<T1, T2, T3> JOBBHNKGDPO<T1, T2, T3>(T1 JMAKBCGCNNC, T2 MDIPGPEINHN, T3 CBGIAPBPJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3ECFAD0", Offset = "0x3ECE6D0", VA = "0x183ECFAD0")]
	internal static int HEBCPPICCKJ(int IIHFNCBDLOB, int KAMHEBNFOJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x551D260", Offset = "0x551BE60", VA = "0x18551D260")]
	internal static int HEBCPPICCKJ(int IIHFNCBDLOB, int KAMHEBNFOJH, int OEJIIPMOKKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AMCCBMCJLBI<T1, T2> : IComparable<AMCCBMCJLBI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 HMGHEDLMFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 KEIOGFLADHJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x38DCB90", Offset = "0x38DB790", VA = "0x1838DCB90")]
	public AMCCBMCJLBI(T1 JMAKBCGCNNC, T2 MDIPGPEINHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x38DB1C0", Offset = "0x38D9DC0", VA = "0x1838DB1C0", Slot = "4")]
	public int CompareTo(AMCCBMCJLBI<T1, T2> NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x38DB7B0", Offset = "0x38DA3B0", VA = "0x1838DB7B0", Slot = "0")]
	public override bool Equals(object NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x38DC0D0", Offset = "0x38DACD0", VA = "0x1838DC0D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x38DC280", Offset = "0x38DAE80", VA = "0x1838DC280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OGOLCPKHEJJ<T1, T2, T3> : IComparable<OGOLCPKHEJJ<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 HMGHEDLMFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 KEIOGFLADHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 JCFCMNKAIPE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x400D570", Offset = "0x400C170", VA = "0x18400D570")]
	public OGOLCPKHEJJ(T1 JMAKBCGCNNC, T2 MDIPGPEINHN, T3 CBGIAPBPJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x400CC30", Offset = "0x400B830", VA = "0x18400CC30", Slot = "4")]
	public int CompareTo(OGOLCPKHEJJ<T1, T2, T3> NAFFCAIMPLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x400CFC0", Offset = "0x400BBC0", VA = "0x18400CFC0", Slot = "0")]
	public override bool Equals(object NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x400D200", Offset = "0x400BE00", VA = "0x18400D200", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x400D2A0", Offset = "0x400BEA0", VA = "0x18400D2A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x212D230", Offset = "0x212BE30", VA = "0x18212D230")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x212D240", Offset = "0x212BE40", VA = "0x18212D240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float DIHBNBKMPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F20", Offset = "0x8B5B20", VA = "0x1808B6F20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x44D3D10", Offset = "0x44D2910", VA = "0x1844D3D10")]
	public T KENIFHJJBFK(float JIGADAOLAJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x44D3B40", Offset = "0x44D2740", VA = "0x1844D3B40")]
	public T JKMHCALPJGO(float JIGADAOLAJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CLDJGLABKLP(T AHIHMLDOCPC, T APNBCADOPPJ, float JIGADAOLAJF);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60F9900", Offset = "0x60F8500", VA = "0x1860F9900", Slot = "4")]
	protected override float CLDJGLABKLP(float AHIHMLDOCPC, float APNBCADOPPJ, float JIGADAOLAJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x60F9940", Offset = "0x60F8540", VA = "0x1860F9940")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xCFA160", Offset = "0xCF8D60", VA = "0x180CFA160", Slot = "4")]
	protected override Vector3 CLDJGLABKLP(Vector3 AHIHMLDOCPC, Vector3 APNBCADOPPJ, float JIGADAOLAJF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60FD680", Offset = "0x60FC280", VA = "0x1860FD680")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60F8620", Offset = "0x60F7220", VA = "0x1860F8620", Slot = "4")]
	protected override Color CLDJGLABKLP(Color AHIHMLDOCPC, Color APNBCADOPPJ, float JIGADAOLAJF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60F86E0", Offset = "0x60F72E0", VA = "0x1860F86E0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FFKCEHDLDFE : FOLMADELNAO<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60F97C0", Offset = "0x60F83C0", VA = "0x1860F97C0")]
	public FFKCEHDLDFE(int LLHBDBHCNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60F9750", Offset = "0x60F8350", VA = "0x1860F9750", Slot = "6")]
	protected override uint PJGMNJIEGBO(uint HCLBLKKJPDE, string BLKAHBIJBJO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FODMIHJGLMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public FODMIHJGLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BENGFIIHAPJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BGCEEKKFLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int ODNDGLPPFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int PPPDMDNGBAJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3678F30", Offset = "0x3677B30", VA = "0x183678F30")]
	private BENGFIIHAPJ(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CIKOFFBIJLC, int HKALHIPCLJE, int MELOLDAMCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x477A5B0", Offset = "0x47791B0", VA = "0x18477A5B0")]
	public static BENGFIIHAPJ<T> CIGBOGDFGOD()
	{
		return default(BENGFIIHAPJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x477B4A0", Offset = "0x477A0A0", VA = "0x18477B4A0")]
	public (int, int, Task<T>) PPCONGDMOPC(int FHDOEPMHPEB, [Optional] CancellationToken EJGJLLMBDIN, double OPCGAFBMLPL = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x477AA40", Offset = "0x4779640", VA = "0x18477AA40")]
	public void NBEOEBJIJFO(int FHDOEPMHPEB, int MELOLDAMCEO, [In] T MGHLKGJFBCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EJFJDCEEAPF
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60F9680", Offset = "0x60F8280", VA = "0x1860F9680")]
	public static BENGFIIHAPJ<BABPIFEMKHH> CIGBOGDFGOD()
	{
		return default(BENGFIIHAPJ<BABPIFEMKHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x60F96D0", Offset = "0x60F82D0", VA = "0x1860F96D0")]
	public static void NBEOEBJIJFO([In] this BENGFIIHAPJ<BABPIFEMKHH> NOLNJDLEMAA, int FHDOEPMHPEB, int MELOLDAMCEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class DAJNAAKCDOL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> DKCCINFLKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> DPCJCOAFBND;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x313B930", Offset = "0x313A530", VA = "0x18313B930", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FHOMOFINOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> AHNOPBBGNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3C05BF0", Offset = "0x3C047F0", VA = "0x183C05BF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> DNMECDMKCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x502F350", Offset = "0x502DF50", VA = "0x18502F350", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x502F2F0", Offset = "0x502DEF0", VA = "0x18502F2F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x502F390", Offset = "0x502DF90", VA = "0x18502F390", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x502ED90", Offset = "0x502D990", VA = "0x18502ED90")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x502E660", Offset = "0x502D260", VA = "0x18502E660", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x502F0D0", Offset = "0x502DCD0", VA = "0x18502F0D0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x502E600", Offset = "0x502D200", VA = "0x18502E600", Slot = "9")]
	public void Add(TKey CGGNJKGENIH, TVal BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x502E630", Offset = "0x502D230", VA = "0x18502E630", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ILDOLMKGCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x334C050", Offset = "0x334AC50", VA = "0x18334C050", Slot = "8")]
	public bool ContainsKey(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x502E6C0", Offset = "0x502D2C0", VA = "0x18502E6C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ILDOLMKGCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x502F040", Offset = "0x502DC40", VA = "0x18502F040", Slot = "10")]
	public bool Remove(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x502F0A0", Offset = "0x502DCA0", VA = "0x18502F0A0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ILDOLMKGCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x502F1C0", Offset = "0x502DDC0", VA = "0x18502F1C0", Slot = "11")]
	public bool TryGetValue(TKey CGGNJKGENIH, [Out] TVal BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x502EA50", Offset = "0x502D650", VA = "0x18502EA50", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x502E750", Offset = "0x502D350", VA = "0x18502E750", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GBCEGNLFFAN, int CLNFPIKMFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x502EFF0", Offset = "0x502DBF0", VA = "0x18502EFF0")]
	public bool PODAMIMAFNE(TVal CGGNJKGENIH, [Out] TKey BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x502EE70", Offset = "0x502DA70", VA = "0x18502EE70")]
	private void PJGFDBBEJEI(TKey CGGNJKGENIH, TVal NOPNOIONIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x502ECA0", Offset = "0x502D8A0", VA = "0x18502ECA0")]
	private void KBJLMGGIBOE(TKey CGGNJKGENIH, TVal NOPNOIONIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x502E7D0", Offset = "0x502D3D0", VA = "0x18502E7D0")]
	private bool FDDPJCOMCGJ(TKey CGGNJKGENIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x502F200", Offset = "0x502DE00", VA = "0x18502F200")]
	public DAJNAAKCDOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class BEAPJCDMFHF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private BEAPJCDMFHF<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x339F170", Offset = "0x339DD70", VA = "0x18339F170", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x33A34E0", Offset = "0x33A20E0", VA = "0x1833A34E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x33A3C50", Offset = "0x33A2850", VA = "0x1833A3C50")]
		public Enumerator(BEAPJCDMFHF<T> KLIMJJKAHFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x339FF20", Offset = "0x339EB20", VA = "0x18339FF20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x33A1F10", Offset = "0x33A0B10", VA = "0x1833A1F10", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x339F4C0", Offset = "0x339E0C0", VA = "0x18339F4C0")]
		private void FAHFKHDNKNK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] KDKGIOJPFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int FAFMJOHFKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int GECBABMIPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int KAHEAPGLNDI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x476F520", Offset = "0x476E120", VA = "0x18476F520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4770850", Offset = "0x476F450", VA = "0x184770850")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4770600", Offset = "0x476F200", VA = "0x184770600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4770DF0", Offset = "0x476F9F0", VA = "0x184770DF0")]
	public BEAPJCDMFHF(int LLHBDBHCNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x476F2F0", Offset = "0x476DEF0", VA = "0x18476F2F0")]
	public void BGJHDHHBMPP(T JIGADAOLAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x476F560", Offset = "0x476E160", VA = "0x18476F560")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4770770", Offset = "0x476F370", VA = "0x184770770")]
	public void MCOGGKNBKHG(int MAJIECOCCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x476FCB0", Offset = "0x476E8B0", VA = "0x18476FCB0")]
	public void GJHHIBAHLEK(T[] GBCEGNLFFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x476F3F0", Offset = "0x476DFF0", VA = "0x18476F3F0")]
	public Enumerator EABNIEGMBCK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4770BB0", Offset = "0x476F7B0", VA = "0x184770BB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4770BB0", Offset = "0x476F7B0", VA = "0x184770BB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4770260", Offset = "0x476EE60", VA = "0x184770260")]
	private int IBMEDNPLEHD(int PMIDLPOCCEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4770820", Offset = "0x476F420", VA = "0x184770820")]
	private int MFFPBBIHFLG(int PMIDLPOCCEE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class EFBJGDOPCEL<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Func<Internal, External> PDLEEDJNCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private IReadOnlyList<Internal> GPOHBJENHCE;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x331CA50", Offset = "0x331B650", VA = "0x18331CA50", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x331CA00", Offset = "0x331B600", VA = "0x18331CA00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public EFBJGDOPCEL(Func<Internal, External> PDLEEDJNCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x331C9B0", Offset = "0x331B5B0", VA = "0x18331C9B0")]
	public EFBJGDOPCEL(IReadOnlyList<Internal> GPOHBJENHCE, Func<Internal, External> PDLEEDJNCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x331C8A0", Offset = "0x331B4A0", VA = "0x18331C8A0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x331C980", Offset = "0x331B580", VA = "0x18331C980", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class CICENHLPKAG<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate Task<TResult> EDDCBHBDCFG(TRequest MLHMNLDOBPP, CancellationToken EJGJLLMBDIN);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum LKBBEPKNJOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class MHEOOPFBINM
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private const float PHLAFPHKFCE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TimeSpan MKNJMIMDGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int JPGLLLDMPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LKBBEPKNJOF EEEDBOMKGCP;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly MHEOOPFBINM IDMMFBJNCBP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float KHCALNKMKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3E27A40", Offset = "0x3E26640", VA = "0x183E27A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan LHFFKLGBHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E27C00", Offset = "0x3E26800", VA = "0x183E27C00")]
		public MHEOOPFBINM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private readonly struct OEKHJKFGLGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TRequest MLHMNLDOBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly CancellationToken EJGJLLMBDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly TaskCompletionSource<TResult> CCLGFPLJJNF;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4006250", Offset = "0x4004E50", VA = "0x184006250")]
		public OEKHJKFGLGG(TRequest MLHMNLDOBPP, TaskCompletionSource<TResult> CCLGFPLJJNF, CancellationToken EJGJLLMBDIN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct JLHGELBDJFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CICENHLPKAG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3B0C350", Offset = "0x3B0AF50", VA = "0x183B0C350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3B0C7F0", Offset = "0x3B0B3F0", VA = "0x183B0C7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct BOAGLMCNHBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public CICENHLPKAG<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private OEKHJKFGLGG <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x47FD5D0", Offset = "0x47FC1D0", VA = "0x1847FD5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x47FDC30", Offset = "0x47FC830", VA = "0x1847FDC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly CancellationTokenSource KBCBLNBEJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<OEKHJKFGLGG> DBHLDACDDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly MHEOOPFBINM PFADCKIHPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EDDCBHBDCFG KPIAMIOFGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Task NAAFFHNJCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private int EEHMBDDGOEG;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4BBF500", Offset = "0x4BBE100", VA = "0x184BBF500")]
	public CICENHLPKAG(EDDCBHBDCFG KPIAMIOFGBH, [Optional] MHEOOPFBINM PFADCKIHPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4BBDF70", Offset = "0x4BBCB70", VA = "0x184BBDF70")]
	public Task<TResult> CIOMEOPKJIM(TRequest MLHMNLDOBPP, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4BBEF70", Offset = "0x4BBDB70", VA = "0x184BBEF70")]
	private void MMIGJNBIAFA(OEKHJKFGLGG NDMLDDAOIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4BBEB10", Offset = "0x4BBD710", VA = "0x184BBEB10")]
	[AsyncStateMachine(typeof(CICENHLPKAG<, >.JLHGELBDJFE))]
	private Task FBFIOFNFAED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4BBE6A0", Offset = "0x4BBD2A0", VA = "0x184BBE6A0")]
	private OEKHJKFGLGG CLFIHBDGEJP()
	{
		return default(OEKHJKFGLGG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4BBECE0", Offset = "0x4BBD8E0", VA = "0x184BBECE0")]
	[AsyncStateMachine(typeof(CICENHLPKAG<, >.BOAGLMCNHBK))]
	private Task JDPMMNNFPHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4BBF1A0", Offset = "0x4BBDDA0", VA = "0x184BBF1A0")]
	private void MOBGNPHFCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4BBE930", Offset = "0x4BBD530", VA = "0x184BBE930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class EFHMGFFNAMK<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly List<T> GPOHBJENHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private HashSet<T> LIMPDJKLAOA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x313B930", Offset = "0x313A530", VA = "0x18313B930", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FHOMOFINOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x331D4C0", Offset = "0x331C0C0", VA = "0x18331D4C0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x331D5E0", Offset = "0x331C1E0", VA = "0x18331D5E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x331CB60", Offset = "0x331B760", VA = "0x18331CB60", Slot = "11")]
	public void Add(T ILDOLMKGCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x331CD10", Offset = "0x331B910", VA = "0x18331CD10")]
	public bool EEDOEBJHJKJ(T ILDOLMKGCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x331D260", Offset = "0x331BE60", VA = "0x18331D260", Slot = "15")]
	public bool Remove(T ILDOLMKGCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x331CDD0", Offset = "0x331B9D0", VA = "0x18331CDD0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x331D3A0", Offset = "0x331BFA0", VA = "0x18331D3A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x331CB80", Offset = "0x331B780", VA = "0x18331CB80", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x331CBE0", Offset = "0x331B7E0", VA = "0x18331CBE0", Slot = "13")]
	public bool Contains(T ILDOLMKGCCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x331CC20", Offset = "0x331B820", VA = "0x18331CC20", Slot = "14")]
	public void CopyTo(T[] GBCEGNLFFAN, int CLNFPIKMFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x331CE60", Offset = "0x331BA60", VA = "0x18331CE60", Slot = "6")]
	public int IndexOf(T ILDOLMKGCCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x331CEB0", Offset = "0x331BAB0", VA = "0x18331CEB0", Slot = "7")]
	public void Insert(int PMIDLPOCCEE, T ILDOLMKGCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x331D170", Offset = "0x331BD70", VA = "0x18331D170", Slot = "8")]
	public void RemoveAt(int PMIDLPOCCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x331D3D0", Offset = "0x331BFD0", VA = "0x18331D3D0")]
	public EFHMGFFNAMK()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1F8F1A0", Offset = "0x1F8DDA0", VA = "0x181F8F1A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60FCD10", Offset = "0x60FB910", VA = "0x1860FCD10")]
		public SerializedGuid([In] Guid AGEGEBLOPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60FCB80", Offset = "0x60FB780", VA = "0x1860FCB80")]
		public static SerializedGuid MCLKAJIHGJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x60FCB10", Offset = "0x60FB710", VA = "0x1860FCB10")]
		public static SerializedGuid ILNEKBFLNCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x60FCCB0", Offset = "0x60FB8B0", VA = "0x1860FCCB0")]
		public bool PGNAFHIBNIJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60FCC80", Offset = "0x60FB880", VA = "0x1860FCC80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x60FCC00", Offset = "0x60FB800", VA = "0x1860FCC00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60FCA30", Offset = "0x60FB630", VA = "0x1860FCA30", Slot = "7")]
		public bool Equals(SerializedGuid NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60FCA70", Offset = "0x60FB670", VA = "0x1860FCA70", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x60FCB00", Offset = "0x60FB700", VA = "0x1860FCB00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x60FCA00", Offset = "0x60FB600", VA = "0x1860FCA00", Slot = "6")]
		public int CompareTo(SerializedGuid NAFFCAIMPLI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FLMNCKDGOKK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly Type LEMOBBBJPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly string GNCECLBILNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly bool IHFHEIIBGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool GJEOKIAPLOK;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x60F9810", Offset = "0x60F8410", VA = "0x1860F9810")]
	public FLMNCKDGOKK(Type EMNCECDNGOD, string KFJNFHKBDGB, bool AOAALOCBKIP = false, bool CDBNPNPCHGA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DBCLHGHLEMD<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct EHPGMIAEEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly long KEHDOADHIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long KKGCDJACBCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly int DKDBLCBAOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int IDGJNDLPLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly bool AAFAACBIMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly string HGAHCPOAFKH;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3326E10", Offset = "0x3325A10", VA = "0x183326E10")]
		public EHPGMIAEEMC(long KEHDOADHIFN, int DKDBLCBAOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3326E80", Offset = "0x3325A80", VA = "0x183326E80")]
		public EHPGMIAEEMC(long KEHDOADHIFN, long KKGCDJACBCN, int DKDBLCBAOJG, int IDGJNDLPLFP, bool AAFAACBIMFL, string HGAHCPOAFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3326CA0", Offset = "0x33258A0", VA = "0x183326CA0")]
		public int AMJEHMMDCCI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3326CF0", Offset = "0x33258F0", VA = "0x183326CF0")]
		public int FENCDMBDLKJ(int PGDPEFJHCKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3326D10", Offset = "0x3325910", VA = "0x183326D10")]
		public double JDIIJJKCKMH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3326D70", Offset = "0x3325970", VA = "0x183326D70")]
		public EHPGMIAEEMC JHCCGLOBJDM(long KKGCDJACBCN, int IDGJNDLPLFP)
		{
			return default(EHPGMIAEEMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class OGCCDEKKEPE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private struct KGHBDHMNGBJ<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public OGCCDEKKEPE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public Func<OGCCDEKKEPE, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private OGCCDEKKEPE <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3B6D5A0", Offset = "0x3B6C1A0", VA = "0x183B6D5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x38DDBF0", Offset = "0x38DC7F0", VA = "0x1838DDBF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly TKey BKEHFHLBEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly DBCLHGHLEMD<TKey> KAMOOCNEONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly HEENJBKIIAO BNEDOBBKLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private List<OGCCDEKKEPE> BLGHCNNICPE;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string BCGDMBPIIEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4008AF0", Offset = "0x40076F0", VA = "0x184008AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<OGCCDEKKEPE> ALKDPFOCKHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x4008B20", Offset = "0x4007720", VA = "0x184008B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public EHPGMIAEEMC LKNFAMEKEKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x4008940", Offset = "0x4007540", VA = "0x184008940")]
			[CompilerGenerated]
			get
			{
				return default(EHPGMIAEEMC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4008960", Offset = "0x4007560", VA = "0x184008960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4008B60", Offset = "0x4007760", VA = "0x184008B60")]
		internal OGCCDEKKEPE(DBCLHGHLEMD<TKey> KAMOOCNEONO, TKey CGGNJKGENIH, HEENJBKIIAO BNEDOBBKLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4008990", Offset = "0x4007590", VA = "0x184008990")]
		public OGCCDEKKEPE MCAJJFHDAAB(TKey CGGNJKGENIH, [Optional] HEENJBKIIAO? JJJHPLHHFHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2724E60", Offset = "0x2723A60", VA = "0x182724E60")]
		[AsyncStateMachine(typeof(KGHBDHMNGBJ<>))]
		public Task<T> MPOILAADMIN<T>(TKey CGGNJKGENIH, Func<OGCCDEKKEPE, Task<T>> HMNHGLIGALO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4008740", Offset = "0x4007340", VA = "0x184008740", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FKAFAJBHAMD : IEnumerable<(TKey, List<TKey>, EHPGMIAEEMC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EHPGMIAEEMC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, EHPGMIAEEMC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DBCLHGHLEMD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private IEnumerator<(TKey key, List<TKey> path, EHPGMIAEEMC timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, EHPGMIAEEMC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1F8FA80", Offset = "0x1F8E680", VA = "0x181F8FA80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EHPGMIAEEMC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x368D680", Offset = "0x368C280", VA = "0x18368D680", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1F8FB70", Offset = "0x1F8E770", VA = "0x181F8FB70")]
		[DebuggerHidden]
		public FKAFAJBHAMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3587500", Offset = "0x3586100", VA = "0x183587500", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x368D1A0", Offset = "0x368BDA0", VA = "0x18368D1A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x368D150", Offset = "0x368BD50", VA = "0x18368D150")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x368D630", Offset = "0x368C230", VA = "0x18368D630", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x368D540", Offset = "0x368C140", VA = "0x18368D540", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EHPGMIAEEMC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x368D600", Offset = "0x368C200", VA = "0x18368D600", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CMBBLLAHDGA : IEnumerable<(TKey, List<TKey>, EHPGMIAEEMC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EHPGMIAEEMC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private (TKey key, List<TKey> path, EHPGMIAEEMC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private OGCCDEKKEPE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public OGCCDEKKEPE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DBCLHGHLEMD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IEnumerator<OGCCDEKKEPE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<(TKey key, List<TKey> path, EHPGMIAEEMC timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, EHPGMIAEEMC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1F8FA80", Offset = "0x1F8E680", VA = "0x181F8FA80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EHPGMIAEEMC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4C94F70", Offset = "0x4C93B70", VA = "0x184C94F70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1F8FB70", Offset = "0x1F8E770", VA = "0x181F8FB70")]
		[DebuggerHidden]
		public CMBBLLAHDGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4C94FD0", Offset = "0x4C93BD0", VA = "0x184C94FD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4C94690", Offset = "0x4C93290", VA = "0x184C94690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4C945D0", Offset = "0x4C931D0", VA = "0x184C945D0")]
		private void DPHAFEJOOLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4C94630", Offset = "0x4C93230", VA = "0x184C94630")]
		private void KFBCLBKCPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4C94F20", Offset = "0x4C93B20", VA = "0x184C94F20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4C94E40", Offset = "0x4C93A40", VA = "0x184C94E40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EHPGMIAEEMC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x42F9460", Offset = "0x42F8060", VA = "0x1842F9460", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<TKey, EHPGMIAEEMC, HEENJBKIIAO> DLEGLDHLOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, EHPGMIAEEMC, HEENJBKIIAO> IPFKAHNHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<DBCLHGHLEMD<TKey>, HEENJBKIIAO> JONHAONMJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly OGCCDEKKEPE MNGBJBLJMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private bool DLLGBEPLAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int AFIEHMHAKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Stopwatch BGCPJNHICKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly int ODCMCFAFFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private string DMLKKPLPCLM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public OGCCDEKKEPE CJFAMNHBFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string BCGDMBPIIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B7990", Offset = "0x7B6590", VA = "0x1807B7990")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x50314D0", Offset = "0x50300D0", VA = "0x1850314D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x50315B0", Offset = "0x50301B0", VA = "0x1850315B0")]
	public DBCLHGHLEMD(TKey DLMGBJNFJFP, HEENJBKIIAO BNEDOBBKLOJ, [Optional] int? DKDBLCBAOJG, [Optional][CanBeNull] Stopwatch BGCPJNHICKN, [Optional] Action<TKey, EHPGMIAEEMC, HEENJBKIIAO> DLEGLDHLOPO, [Optional] Action<TKey, EHPGMIAEEMC, HEENJBKIIAO> IPFKAHNHGLN, [Optional] Action<DBCLHGHLEMD<TKey>, HEENJBKIIAO> JONHAONMJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x50312E0", Offset = "0x502FEE0", VA = "0x1850312E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5031440", Offset = "0x5030040", VA = "0x185031440")]
	[IteratorStateMachine(typeof(DBCLHGHLEMD<>.FKAFAJBHAMD))]
	public IEnumerable<(TKey, List<TKey>, EHPGMIAEEMC)> JNMMIIACPNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5031370", Offset = "0x502FF70", VA = "0x185031370")]
	[IteratorStateMachine(typeof(DBCLHGHLEMD<>.CMBBLLAHDGA))]
	private IEnumerable<(TKey, List<TKey>, EHPGMIAEEMC)> JNMMIIACPNP(List<TKey> CMCOOMKLEBK, OGCCDEKKEPE IBOCOJDOBPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5031530", Offset = "0x5030130", VA = "0x185031530")]
	private (long, int) OIBPIFAMGNF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class NBPDBPFBJKC<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut DMECDFGEIJA(DBCLHGHLEMD<TKey> KAMOOCNEONO);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected NBPDBPFBJKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public abstract class LNPJCIGCAFJ<TKey> : NBPDBPFBJKC<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate string OGBHOFCOJLM(TKey CGGNJKGENIH);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3C3EA60", Offset = "0x3C3D660", VA = "0x183C3EA60")]
	private static string BBOOMMMDOHJ(TKey CGGNJKGENIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3C3EBF0", Offset = "0x3C3D7F0", VA = "0x183C3EBF0", Slot = "4")]
	public override string DMECDFGEIJA(DBCLHGHLEMD<TKey> KAMOOCNEONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C3EAA0", Offset = "0x3C3D6A0", VA = "0x183C3EAA0")]
	public string DMECDFGEIJA(DBCLHGHLEMD<TKey> KAMOOCNEONO, [NotNull] OGBHOFCOJLM BIOKECNJLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string OAANCPCACEA(DBCLHGHLEMD<TKey> KAMOOCNEONO, [NotNull] OGBHOFCOJLM BIOKECNJLNO);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x396CE80", Offset = "0x396BA80", VA = "0x18396CE80")]
	protected LNPJCIGCAFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class PLIOMGOFMIB<TKey> : NBPDBPFBJKC<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string KEFCDGJGPAK(TKey CGGNJKGENIH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly string KGOKILPBDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly double KHMBGNPIGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly bool DJOAKMAPGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly int HLJIKGJDGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly ISet<string> HJJEKFIONFK;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x411D6F0", Offset = "0x411C2F0", VA = "0x18411D6F0")]
	private static string BBOOMMMDOHJ(TKey CGGNJKGENIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x411E260", Offset = "0x411CE60", VA = "0x18411E260")]
	public PLIOMGOFMIB(string KGOKILPBDIJ = "F2", double KHMBGNPIGKD = double.MaxValue, bool DJOAKMAPGMO = false, int HLJIKGJDGHB = int.MaxValue, [Optional] ISet<string> HJJEKFIONFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x411D730", Offset = "0x411C330", VA = "0x18411D730", Slot = "4")]
	public override Dictionary<string, string> DMECDFGEIJA(DBCLHGHLEMD<TKey> KAMOOCNEONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x411DF40", Offset = "0x411CB40", VA = "0x18411DF40")]
	private bool PECMJNEJNPN(string NFNPFDFMOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x411D7F0", Offset = "0x411C3F0", VA = "0x18411D7F0")]
	public Dictionary<string, string> DMECDFGEIJA(DBCLHGHLEMD<TKey> KAMOOCNEONO, KEFCDGJGPAK BIOKECNJLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x411E020", Offset = "0x411CC20", VA = "0x18411E020")]
	private string PKHAGGEJAEF(StringBuilder DHKEJLMDAAK, List<TKey> CAIGELNBMFK, KEFCDGJGPAK BIOKECNJLNO, bool IOIIPNHCHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x411DDE0", Offset = "0x411C9E0", VA = "0x18411DDE0")]
	private static void OGDINICEKGN(StringBuilder BAPEHLEAGFD, string JFFJOJEKANI, bool LKNDPNPOBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JNEOIFDOEGC<TKey> : LNPJCIGCAFJ<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct EFCKELBOADD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public OGBHOFCOJLM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static JNEOIFDOEGC<TKey> EJGFFMEDDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly string[] NPGHNDHFMLP;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3B14A20", Offset = "0x3B13620", VA = "0x183B14A20")]
	private JNEOIFDOEGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3B13AB0", Offset = "0x3B126B0", VA = "0x183B13AB0", Slot = "5")]
	protected override string OAANCPCACEA(DBCLHGHLEMD<TKey> KAMOOCNEONO, OGBHOFCOJLM BIOKECNJLNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3B139C0", Offset = "0x3B125C0", VA = "0x183B139C0")]
	[CompilerGenerated]
	internal static string FCMDHGJKBCH(string ANKJFPOJHMJ, TKey CGGNJKGENIH, EFCKELBOADD P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class CCOOOIFGHLP : DBCLHGHLEMD<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BPKIGEGIBKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Action<CCOOOIFGHLP, HEENJBKIIAO> callback;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BPKIGEGIBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x60F8210", Offset = "0x60F6E10", VA = "0x1860F8210")]
		internal void FHKNEJOCJMN(DBCLHGHLEMD<string> timer, HEENJBKIIAO log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x60F84D0", Offset = "0x60F70D0", VA = "0x1860F84D0")]
	public CCOOOIFGHLP(HEENJBKIIAO BNEDOBBKLOJ, [Optional] string PNGGLPDCKFF, [Optional] int? DKDBLCBAOJG, [Optional] Stopwatch BGCPJNHICKN, [Optional] Action<string, EHPGMIAEEMC, HEENJBKIIAO> DLEGLDHLOPO, [Optional] Action<string, EHPGMIAEEMC, HEENJBKIIAO> IPFKAHNHGLN, [Optional] Action<CCOOOIFGHLP, HEENJBKIIAO> JONHAONMJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x60F8410", Offset = "0x60F7010", VA = "0x1860F8410")]
	private static Action<DBCLHGHLEMD<string>, HEENJBKIIAO> KAOBIMPOHLI(Action<CCOOOIFGHLP, HEENJBKIIAO> NLOLPKLGIBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public abstract class CCIPAPCIKGI
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private class HFICPIMFBEN : CCIPAPCIKGI
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static CCIPAPCIKGI EJGFFMEDDPG
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x60F9EB0", Offset = "0x60F8AB0", VA = "0x1860F9EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float LJJLEJELBHN
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1DBB490", Offset = "0x1DBA090", VA = "0x181DBB490", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x60F9FB0", Offset = "0x60F8BB0", VA = "0x1860F9FB0")]
		public HFICPIMFBEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static CCIPAPCIKGI MAOCFPDHAMF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static CCIPAPCIKGI IDMMFBJNCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x60F82A0", Offset = "0x60F6EA0", VA = "0x1860F82A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float LJJLEJELBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected CCIPAPCIKGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IELECAGHLGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool CPEAOGPNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface EICCGEEHPKI<T> : IELECAGHLGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> BGLMDPPHPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	LHJBMADJJFP<T> JPBIOGLJEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OCMLGFNBLOP
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class PGAHDKHPCCG<T> : OPHIBIFPHOD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> BGLMDPPHPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override LHJBMADJJFP<T?> JPBIOGLJEOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4100F30", Offset = "0x40FFB30", VA = "0x184100F30")]
		public PGAHDKHPCCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "10")]
		protected override void DLGLFADBMIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class ANNGDOABEOL<T> : OPHIBIFPHOD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> BGLMDPPHPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override LHJBMADJJFP<T> JPBIOGLJEOB
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x38E51E0", Offset = "0x38E3DE0", VA = "0x1838E51E0")]
		public ANNGDOABEOL(Exception PKPFNALFKGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "10")]
		protected override void DLGLFADBMIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class CADJKINABGI<T> : OPHIBIFPHOD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct EPLNIHPIKDK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public Task<EICCGEEHPKI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private TaskAwaiter<EICCGEEHPKI<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3350400", Offset = "0x334F000", VA = "0x183350400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x33508F0", Offset = "0x334F4F0", VA = "0x1833508F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct HOOFLAGJLDK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<EICCGEEHPKI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<EICCGEEHPKI<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x388C080", Offset = "0x388AC80", VA = "0x18388C080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x388C2B0", Offset = "0x388AEB0", VA = "0x18388C2B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Task<EICCGEEHPKI<T>> DAIDAAMLHEL;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> BGLMDPPHPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override LHJBMADJJFP<T> JPBIOGLJEOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4AD9970", Offset = "0x4AD8570", VA = "0x184AD9970")]
		public CADJKINABGI(Task<EICCGEEHPKI<T>> BKPEJJIHAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4AD9690", Offset = "0x4AD8290", VA = "0x184AD9690", Slot = "10")]
		protected override void DLGLFADBMIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4AD9810", Offset = "0x4AD8410", VA = "0x184AD9810")]
		[AsyncStateMachine(typeof(CADJKINABGI<>.EPLNIHPIKDK))]
		[CompilerGenerated]
		internal static Task<T> KOHBOLDHHDO(Task<EICCGEEHPKI<T>> BKPEJJIHAHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4AD9720", Offset = "0x4AD8320", VA = "0x184AD9720")]
		[AsyncStateMachine(typeof(CADJKINABGI<>.HOOFLAGJLDK))]
		[CompilerGenerated]
		internal static Task KCHEJPHBLOP(Task<EICCGEEHPKI<T>> BKPEJJIHAHC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2933820", Offset = "0x2932420", VA = "0x182933820")]
	public static EICCGEEHPKI<T> ONLHDLNPPFP<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2690E60", Offset = "0x268FA60", VA = "0x182690E60")]
	public static EICCGEEHPKI<T> CIDIAGAKGMI<T>(Exception PKPFNALFKGI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2690E60", Offset = "0x268FA60", VA = "0x182690E60")]
	public static EICCGEEHPKI<T> GEIMDKBEGLC<T>(Task<EICCGEEHPKI<T>> BKPEJJIHAHC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class OPHIBIFPHOD<T> : EICCGEEHPKI<T>, IELECAGHLGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly string DNGEJDJPFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly PMKDBMIPKGM GDLDEGKFOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool DLLGBEPLAAB;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CPEAOGPNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA09E00", Offset = "0xA08A00", VA = "0x180A09E00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public abstract Task<T> BGLMDPPHPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public abstract LHJBMADJJFP<T> JPBIOGLJEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x403E810", Offset = "0x403D410", VA = "0x18403E810")]
	public OPHIBIFPHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x403E490", Offset = "0x403D090", VA = "0x18403E490", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DLGLFADBMIH();
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class NOMFABANADJ<TTask, T> : OPHIBIFPHOD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class NBIJKFFCLPG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public NBIJKFFCLPG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x312B620", Offset = "0x312A220", VA = "0x18312B620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x312B8F0", Offset = "0x312A4F0", VA = "0x18312B8F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NOMFABANADJ<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public NBIJKFFCLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3EE1E40", Offset = "0x3EE0A40", VA = "0x183EE1E40")]
		[AsyncStateMachine(typeof(NOMFABANADJ<, >.NBIJKFFCLPG.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> CHFONNHBMKH(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Task<T> BKPEJJIHAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected readonly CancellationTokenSource PMGENMHPOOO;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> BGLMDPPHPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override LHJBMADJJFP<T> JPBIOGLJEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3F53C80", Offset = "0x3F52880", VA = "0x183F53C80")]
	protected NOMFABANADJ(TTask BKPEJJIHAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3F53890", Offset = "0x3F52490", VA = "0x183F53890", Slot = "10")]
	protected override void DLGLFADBMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T APHFPNEDKKJ(TTask BBCDFCFEEPN);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void MCLAOJBLPMN();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class ENMBAGFAAFM<T> : OPHIBIFPHOD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly LENMHFABFBO<Task<T>> PGPGLJAHAON;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> BGLMDPPHPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x334CA40", Offset = "0x334B640", VA = "0x18334CA40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override LHJBMADJJFP<T> JPBIOGLJEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x334CA80", Offset = "0x334B680", VA = "0x18334CA80")]
	public ENMBAGFAAFM(LENMHFABFBO<Task<T>> EBIICDNCEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x334CA20", Offset = "0x334B620", VA = "0x18334CA20", Slot = "10")]
	protected override void DLGLFADBMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class GJIBOKJIHGC
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x60F9980", Offset = "0x60F8580", VA = "0x1860F9980")]
	[NotNull]
	public static byte[] EEGOHIMLAGN(this HNCKGPAFGOJ MKGLLLLJJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x60F99F0", Offset = "0x60F85F0", VA = "0x1860F99F0")]
	[NotNull]
	public static byte[] EEGOHIMLAGN(this HNCKGPAFGOJ MKGLLLLJJHB, HashAlgorithmName FDEGCFIINMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x60F9D20", Offset = "0x60F8920", VA = "0x1860F9D20")]
	public static bool MKHMBHIJCMI([CanBeNull] this HNCKGPAFGOJ MKGLLLLJJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x60F9B80", Offset = "0x60F8780", VA = "0x1860F9B80")]
	public static bool MKHMBHIJCMI([CanBeNull] this HNCKGPAFGOJ MKGLLLLJJHB, [Out] string JDDBJGCFGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x60F9A60", Offset = "0x60F8660", VA = "0x1860F9A60")]
	private static bool HIJHIJCGPDM([NotNull] HNCKGPAFGOJ MKGLLLLJJHB, [Out][CanBeNull] byte[] GLAFMKPAHGM, [Out][CanBeNull] byte[] EFHGGHLENHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class MBAJNGHBADM
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x60FA660", Offset = "0x60F9260", VA = "0x1860FA660")]
	[NotNull]
	public static byte[] EEGOHIMLAGN(this BGDIIHANLOF EHNPOMHKBNB, HashAlgorithmName FDEGCFIINMK, byte[] MILCMNMGJCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface BGDIIHANLOF
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash HCLBLKKJPDE);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface HNCKGPAFGOJ : BGDIIHANLOF
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	[CanBeNull]
	byte[] AJGFGEIECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	[CanBeNull]
	byte[] IKDEDDDBDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class OCOGHMHJGKF
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly ArrayPool<byte> BIAOADCPBLM;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static bool MMIFIJGNHIA;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2933F40", Offset = "0x2932B40", VA = "0x182933F40")]
	public static void OLONCGIEJMM<T>(this IncrementalHash AONLLDNLCMB, [CanBeNull] T AHNMMBDFHCD) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2933EB0", Offset = "0x2932AB0", VA = "0x182933EB0")]
	public static void IOEENAFEFFK<T>(this IncrementalHash AONLLDNLCMB, [CanBeNull] T EHNPOMHKBNB) where T : BGDIIHANLOF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2934000", Offset = "0x2932C00", VA = "0x182934000")]
	public static void POAIFBFMBIN<T>(this IncrementalHash AONLLDNLCMB, [CanBeNull] IList<T> KKILJKCPIMC) where T : BGDIIHANLOF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x60FA920", Offset = "0x60F9520", VA = "0x1860FA920")]
	private static bool AEEDPIMNKBE([CanBeNull] BGDIIHANLOF EHNPOMHKBNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x60FAB80", Offset = "0x60F9780", VA = "0x1860FAB80")]
	public static void FGILGMCIEBD(this IncrementalHash HCLBLKKJPDE, [CanBeNull] string BDNJGJLKKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x60FB2E0", Offset = "0x60F9EE0", VA = "0x1860FB2E0")]
	public static void PEJOAKDLOMB(this IncrementalHash HCLBLKKJPDE, long KGOKFAIKDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x60FB110", Offset = "0x60F9D10", VA = "0x1860FB110")]
	public static void OFKEBGNMJDF(this IncrementalHash HCLBLKKJPDE, int BGPMONEKHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x60FAEE0", Offset = "0x60F9AE0", VA = "0x1860FAEE0")]
	public static void LMHEBABGKFD(this IncrementalHash HCLBLKKJPDE, short KCIKCJAIOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x60FAD70", Offset = "0x60F9970", VA = "0x1860FAD70")]
	public static void KHJCFEKNAHC(this IncrementalHash HCLBLKKJPDE, byte GACPOCMNMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x60FAA10", Offset = "0x60F9610", VA = "0x1860FAA10")]
	public static void DLICHFADAFF(this IncrementalHash HCLBLKKJPDE, bool DEANIBBEPBL, bool HMAKBBNGHDL = false, bool MDEBOLHALGC = false, bool JLMCPEBCGAF = false, bool KABDANLLCKP = false, bool BPLLPHJNJEK = false, bool PJFIAECIHBN = false, bool HNIADILLLED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2933880", Offset = "0x2932480", VA = "0x182933880")]
	public static void DOLKLGMOJJP<T>(this IncrementalHash HCLBLKKJPDE, T DIOIMJEHEHI) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x60FA9B0", Offset = "0x60F95B0", VA = "0x1860FA9B0")]
	public static void CCGPJPKHGCO(this IncrementalHash HCLBLKKJPDE, float GIIFALNGMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x60FAE80", Offset = "0x60F9A80", VA = "0x1860FAE80")]
	public static void KMAPJHENPEI(this IncrementalHash HCLBLKKJPDE, ulong ILCAEAAJCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x60FB0B0", Offset = "0x60F9CB0", VA = "0x1860FB0B0")]
	public static void NFHMEEOGDFD(this IncrementalHash HCLBLKKJPDE, uint KLEAGNGCKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x60FAD10", Offset = "0x60F9910", VA = "0x1860FAD10")]
	public static void GCMPLBEMJDD(this IncrementalHash HCLBLKKJPDE, ushort KGPBBPECMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x60FABE0", Offset = "0x60F97E0", VA = "0x1860FABE0")]
	public static void FHLLBBIEHKP(this IncrementalHash HCLBLKKJPDE, Vector3 FCABPKPHEEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HMBCALOPNLB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x60FA000", Offset = "0x60F8C00", VA = "0x1860FA000")]
	public HMBCALOPNLB(string COECLHOAJJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class NLJOAACCPNG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal class JIKICAEKCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TNode NOLNJDLEMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TNode MJOMMKLGFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public CKODIDBFFPJ EGGCNLDBDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public List<CKODIDBFFPJ> KJGKOIPLIGM;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public JIKICAEKCHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal struct CKODIDBFFPJ : IComparable<CKODIDBFFPJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public int JKKEGEHBAJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TClaimant NPEEJBGOEKG;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xC4B980", Offset = "0xC4A580", VA = "0x180C4B980")]
		public CKODIDBFFPJ(int JKKEGEHBAJJ, TClaimant NPEEJBGOEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4C92810", Offset = "0x4C91410", VA = "0x184C92810")]
		public bool KILEMFNNDIL([In] CKODIDBFFPJ NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4C927F0", Offset = "0x4C913F0", VA = "0x184C927F0")]
		public bool BDBFHKFBFKI([In] CKODIDBFFPJ NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4C92800", Offset = "0x4C91400", VA = "0x184C92800", Slot = "4")]
		public int CompareTo(CKODIDBFFPJ NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4C92870", Offset = "0x4C91470", VA = "0x184C92870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public enum IOAIDCLHJDH
	{
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class OJDGPKBLPFI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public NLJOAACCPNG<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x808950", Offset = "0x807550", VA = "0x180808950")]
		[DebuggerHidden]
		public OJDGPKBLPFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x40298F0", Offset = "0x40284F0", VA = "0x1840298F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4029AB0", Offset = "0x40286B0", VA = "0x184029AB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x40299D0", Offset = "0x40285D0", VA = "0x1840299D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x36AC510", Offset = "0x36AB110", VA = "0x1836AC510", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly GPJPJMEBCMC<JIKICAEKCHK> MINOLEGDJFE;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly GPJPJMEBCMC<List<CKODIDBFFPJ>> LJOGGNAOLHK;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static int MCIHGGKJFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	internal readonly Dictionary<TClaimant, TNode> OLGDMMJLBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	internal readonly Dictionary<TNode, JIKICAEKCHK> HOJIMAOEJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private IOAIDCLHJDH HJPHBEGAFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool KLIIIEHJHJF;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode CCJLMHPHJPE(TNode FJKJNIMGBPD);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DLMFNKMIGGJ(TNode FJKJNIMGBPD, TClaimant JHCGOJDFOAP, TClaimant HAGJCHIGHOC);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3F35EB0", Offset = "0x3F34AB0", VA = "0x183F35EB0")]
	public NLJOAACCPNG(IOAIDCLHJDH HJPHBEGAFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3F35920", Offset = "0x3F34520", VA = "0x183F35920")]
	public void NAIPKJMLGOA(TNode FJKJNIMGBPD, TNode AECJKOCMHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3F35120", Offset = "0x3F33D20", VA = "0x183F35120")]
	public void HOKOJOKHGJA(TClaimant NPEEJBGOEKG, TNode IIPHAKHEFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3F34E20", Offset = "0x3F33A20", VA = "0x183F34E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3F34FF0", Offset = "0x3F33BF0", VA = "0x183F34FF0")]
	private void EPADPEFJNFL(TClaimant NPEEJBGOEKG, TNode IKIIMKPJEHH, TNode IIPHAKHEFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3F35550", Offset = "0x3F34150", VA = "0x183F35550")]
	private int JBCNLPINCLK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3F359B0", Offset = "0x3F345B0", VA = "0x183F359B0")]
	private void NFHGLEHMFBM(TClaimant NPEEJBGOEKG, TNode BEDGEJJNDFL, TNode NAGHNCKEKNC, int JKHBFJJODKM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3F35090", Offset = "0x3F33C90", VA = "0x183F35090")]
	private void EPBIFCKJDIC(CKODIDBFFPJ MEODBKELOLI, JIKICAEKCHK MHHDCKCJJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3F34690", Offset = "0x3F33290", VA = "0x183F34690")]
	private void AECCLMAAACO(TClaimant NPEEJBGOEKG, TNode BEDGEJJNDFL, TNode NAGHNCKEKNC, int JKHBFJJODKM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3F35730", Offset = "0x3F34330", VA = "0x183F35730")]
	private void MFDMPHHKPKD(CKODIDBFFPJ MEODBKELOLI, TNode FJKJNIMGBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3F35330", Offset = "0x3F33F30", VA = "0x183F35330")]
	private void IOEDPPLBLLO(CKODIDBFFPJ MEODBKELOLI, JIKICAEKCHK MHHDCKCJJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3F35420", Offset = "0x3F34020", VA = "0x183F35420")]
	private void IPHMEHCBFOO(JIKICAEKCHK MHHDCKCJJOL, bool PEKKMGMDHFG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3F34970", Offset = "0x3F33570", VA = "0x183F34970")]
	private void AMBCHKIFFDH(JIKICAEKCHK MHHDCKCJJOL, TNode AECJKOCMHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3F35840", Offset = "0x3F34440", VA = "0x183F35840")]
	[IteratorStateMachine(typeof(NLJOAACCPNG<, >.OJDGPKBLPFI))]
	private IEnumerable<TNode> MHFIKPJGDHD(TNode BEDGEJJNDFL, TNode NAGHNCKEKNC, bool MDCEEJDHFNM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3F35240", Offset = "0x3F33E40", VA = "0x183F35240")]
	private JIKICAEKCHK IKLDEMLPBFJ(TNode FJKJNIMGBPD, TNode MJOMMKLGFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3F34CB0", Offset = "0x3F338B0", VA = "0x183F34CB0")]
	private JIKICAEKCHK CEAFINHKPKB(TNode FJKJNIMGBPD, TNode MJOMMKLGFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3F355C0", Offset = "0x3F341C0", VA = "0x183F355C0")]
	private void JDPBKDLHPGE(JIKICAEKCHK MHHDCKCJJOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class FOLMADELNAO<T> : IEnumerable<FOLMADELNAO<T>.DPCOBAMCKPP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct DPCOBAMCKPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public T BLKAHBIJBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int PMIDLPOCCEE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class MCJLDKLMHLE : IEnumerator<DPCOBAMCKPP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private FOLMADELNAO<T> BALKPKELLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int PMIDLPOCCEE;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x33556D0", Offset = "0x33542D0", VA = "0x1833556D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DPCOBAMCKPP DDCJPGOIIOH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3E12A40", Offset = "0x3E11640", VA = "0x183E12A40", Slot = "4")]
			get
			{
				return default(DPCOBAMCKPP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E12A00", Offset = "0x3E11600", VA = "0x183E12A00")]
		public MCJLDKLMHLE(FOLMADELNAO<T> BALKPKELLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E12980", Offset = "0x3E11580", VA = "0x183E12980", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x33A8EF0", Offset = "0x33A7AF0", VA = "0x1833A8EF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x869E70", Offset = "0x868A70", VA = "0x180869E70", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private struct PDNBEEMKCJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public bool KGMOEOFIKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public T BLKAHBIJBJO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private const int IEKBACCEKDP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Dictionary<T, int> BFHINHBEFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private PDNBEEMKCJD[] MLIGGLGMCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int HHDFCNHDKOJ;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int CEMFJBLIHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCF0", Offset = "0x7EE8F0", VA = "0x1807EFCF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF920", Offset = "0x7EE520", VA = "0x1807EF920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x313B930", Offset = "0x313A530", VA = "0x18313B930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x36A1630", Offset = "0x36A0230", VA = "0x1836A1630")]
	public FOLMADELNAO(int LLHBDBHCNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x36A1710", Offset = "0x36A0310", VA = "0x1836A1710")]
	public FOLMADELNAO(DPCOBAMCKPP[] MMODFPNLPJG, bool HHMBAHNDGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x36A0F80", Offset = "0x369FB80", VA = "0x1836A0F80")]
	public int HCCFAJHKJNJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x36A1010", Offset = "0x369FC10", VA = "0x1836A1010")]
	private int ILDPPODAADJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x36A1580", Offset = "0x36A0180", VA = "0x1836A1580", Slot = "6")]
	protected virtual uint PJGMNJIEGBO(uint HCLBLKKJPDE, T BLKAHBIJBJO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x36A0F30", Offset = "0x369FB30", VA = "0x1836A0F30")]
	public bool FFNOFAOGPCB(T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x36A0960", Offset = "0x369F560", VA = "0x1836A0960")]
	public int BLCGPNHGJDD(T BLKAHBIJBJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x36A1440", Offset = "0x36A0040", VA = "0x1836A1440")]
	public T IMKAICILMGH(int PMIDLPOCCEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x36A0A20", Offset = "0x369F620", VA = "0x1836A0A20")]
	public bool EEDOEBJHJKJ(T BLKAHBIJBJO, bool AEBKOMANPOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x36A0A70", Offset = "0x369F670", VA = "0x1836A0A70")]
	public bool EEDOEBJHJKJ(T BLKAHBIJBJO, int PMIDLPOCCEE, bool AEBKOMANPOI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x36A1500", Offset = "0x36A0100", VA = "0x1836A1500")]
	private int KGHAIEHGHNG(int FAFMJOHFKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x36A15B0", Offset = "0x36A01B0", VA = "0x1836A15B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x36A15B0", Offset = "0x36A01B0", VA = "0x1836A15B0", Slot = "4")]
	private IEnumerator<DPCOBAMCKPP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GPJPJMEBCMC<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Stack<T> JFPDLOEBMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<T> PLDHLHMBCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly int HGBAOGMLAGI;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x37B70E0", Offset = "0x37B5CE0", VA = "0x1837B70E0")]
	public static GPJPJMEBCMC<T> EJGLCKAEPOG(int LLHBDBHCNGJ = 0, int HGBAOGMLAGI = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x37B6EC0", Offset = "0x37B5AC0", VA = "0x1837B6EC0")]
	public static GPJPJMEBCMC<T> CELOPEGNDKN(int LLHBDBHCNGJ = 0, int HGBAOGMLAGI = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x37B76A0", Offset = "0x37B62A0", VA = "0x1837B76A0")]
	public GPJPJMEBCMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x37B76D0", Offset = "0x37B62D0", VA = "0x1837B76D0")]
	public GPJPJMEBCMC(int LLHBDBHCNGJ, int HGBAOGMLAGI = int.MaxValue, bool LBJLEPAGNBG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x37B72A0", Offset = "0x37B5EA0", VA = "0x1837B72A0")]
	public T ODBNGBAIGII()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x37B6DF0", Offset = "0x37B59F0", VA = "0x1837B6DF0")]
	public void CAHHFGLKLDH(T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x37B71C0", Offset = "0x37B5DC0", VA = "0x1837B71C0")]
	private void FGAJMIBFJNP(T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x37B6DD0", Offset = "0x37B59D0", VA = "0x1837B6DD0")]
	private void APNBCFHNKDE(T BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x37B6FA0", Offset = "0x37B5BA0", VA = "0x1837B6FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x37B7420", Offset = "0x37B6020", VA = "0x1837B7420")]
	private void OKMGGCDAPFM(IEnumerable<T> BEGLJNBNMKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DNHGONCAPGP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<int, T> MCNKNEKLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private T IKHFJCHDOBM;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public virtual T KDOCDKIKNIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B30", Offset = "0x7B1730", VA = "0x1807B2B30", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x50637D0", Offset = "0x50623D0", VA = "0x1850637D0")]
	public bool KMCELLHAPCK(T BLKAHBIJBJO, int JKKEGEHBAJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x369F720", Offset = "0x369E320", VA = "0x18369F720")]
	public bool GJCMIPAODGB(int JKKEGEHBAJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5063570", Offset = "0x5062170", VA = "0x185063570")]
	public T HEGECILGNEJ(int OPHALKIBHKA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x50631D0", Offset = "0x5061DD0", VA = "0x1850631D0")]
	private bool BBBPHPEHGPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5063850", Offset = "0x5062450", VA = "0x185063850")]
	public bool PODAMIMAFNE(int JKKEGEHBAJJ, [Out] T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x50638A0", Offset = "0x50624A0", VA = "0x1850638A0")]
	public DNHGONCAPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class OGFINDJHEAA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	protected struct CGMCOPEFJGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public T BLAEOCKJGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int FBIPALDFKLO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	protected readonly List<CGMCOPEFJGM> KDKGIOJPFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private T LHOGCJOMCEC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x313B930", Offset = "0x313A530", VA = "0x18313B930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4009220", Offset = "0x4007E20", VA = "0x184009220")]
	public bool FLAHJEGFLKH(T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4008ED0", Offset = "0x4007AD0", VA = "0x184008ED0")]
	public void BGJHDHHBMPP(T BLKAHBIJBJO, int JKKEGEHBAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4008F70", Offset = "0x4007B70", VA = "0x184008F70")]
	public bool DMBJGENFJDP(T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x40093A0", Offset = "0x4007FA0", VA = "0x1840093A0")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4009400", Offset = "0x4008000", VA = "0x184009400")]
	public T NPNFECIKGMC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x40090C0", Offset = "0x4007CC0", VA = "0x1840090C0")]
	private void EHJOJBNPIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4009480", Offset = "0x4008080", VA = "0x184009480")]
	public OGFINDJHEAA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		[FEGNHPIOBHH(NNBAHLKNBEN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x60FB700", Offset = "0x60FA300", VA = "0x1860FB700")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x60FB9D0", Offset = "0x60FA5D0", VA = "0x1860FB9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x60FB8E0", Offset = "0x60FA4E0", VA = "0x1860FB8E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x60FB650", Offset = "0x60FA250", VA = "0x1860FB650")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x60FB920", Offset = "0x60FA520", VA = "0x1860FB920")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x60FB830", Offset = "0x60FA430", VA = "0x1860FB830")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x60FB5C0", Offset = "0x60FA1C0", VA = "0x1860FB5C0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x42AF680", Offset = "0x42AE280", VA = "0x1842AF680", Slot = "4")]
		public virtual T ABAPFAJLNAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class EEEMAINFHNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Dictionary<byte, IJFKDKOGPNP> HHOOHCHFPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly GPJPJMEBCMC<IJFKDKOGPNP> CPOKJOLCBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly bool BBFCNBOFKGA;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public IJFKDKOGPNP NAANAJDHGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 PJIHLEHJICO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xBB71D0", Offset = "0xBB5DD0", VA = "0x180BB71D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xEA4170", Offset = "0xEA2D70", VA = "0x180EA4170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private Vector2 NHNLMHOGFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xEE4470", Offset = "0xEE3070", VA = "0x180EE4470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 CJNEJDPHGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x60F8EA0", Offset = "0x60F7AA0", VA = "0x1860F8EA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B9E60", Offset = "0x7B8A60", VA = "0x1807B9E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int MJELECMEGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B80", Offset = "0x7B1780", VA = "0x1807B2B80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D80", Offset = "0x7B1980", VA = "0x1807B2D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x60F91F0", Offset = "0x60F7DF0", VA = "0x1860F91F0")]
	public EEEMAINFHNB(Bounds DMKGMPFOECF, Vector2[] FNLJFBIJNMB, int MCEJJDINDNH, byte FAFMJOHFKBE, float KFAIKJEGGOM = 0f, [Optional] GPJPJMEBCMC<IJFKDKOGPNP> CPOKJOLCBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x60F8EC0", Offset = "0x60F7AC0", VA = "0x1860F8EC0")]
	public IJFKDKOGPNP KBBLAINKJGF(byte PMIDLPOCCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x60F8F20", Offset = "0x60F7B20", VA = "0x1860F8F20")]
	public void MAEOBELKBFO(Vector3 GMKEEAOHFFK, float KOJGOKMBBJK, float EMPBHPEFJKG, List<byte> ANBIGHEODDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x58785B0", Offset = "0x58771B0", VA = "0x1858785B0")]
	public void NJNJIFBLMNK(IJFKDKOGPNP.EMMGIBGHALO KLFIBHOCAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x60F8720", Offset = "0x60F7320", VA = "0x1860F8720")]
	public static int CAIOAAKFMPA(Vector2[] FNLJFBIJNMB, int MCEJJDINDNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x60F8FF0", Offset = "0x60F7BF0", VA = "0x1860F8FF0")]
	private IJFKDKOGPNP PPJOCHBKEHD(byte PMIDLPOCCEE, IJFKDKOGPNP.DIPJDMJFLAM PDNHJDOIGGA, IJFKDKOGPNP MJOMMKLGFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x60F8810", Offset = "0x60F7410", VA = "0x1860F8810")]
	private void DBOALIAMHDI(IJFKDKOGPNP MJOMMKLGFIJ, Vector2[] FNLJFBIJNMB, int CCONPOLBMIL, int BIFHJGIABIB, int CNJGAHDDMGN, int HJFMNIJKLAM, float KFAIKJEGGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x60F8C80", Offset = "0x60F7880", VA = "0x1860F8C80")]
	private void HKBGOKLJHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x60F8BC0", Offset = "0x60F77C0", VA = "0x1860F8BC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x60F8C20", Offset = "0x60F7820", VA = "0x1860F8C20", Slot = "1")]
	~EEEMAINFHNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class IJFKDKOGPNP
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum DIPJDMJFLAM
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum EMMGIBGHALO
	{
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public byte BIEADNMOJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector3 IKCNJIGBKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Vector3 EDIMMLFINLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Vector3 NHLLDDHIPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Vector3 CBCGJHPHANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public DIPJDMJFLAM ANGIDFBDOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public IJFKDKOGPNP CJONHGOLKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public List<IJFKDKOGPNP> JOPLGDOJGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool IIOONCGMEEG;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x60FA4D0", Offset = "0x60F90D0", VA = "0x1860FA4D0")]
	public IJFKDKOGPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x60FA0F0", Offset = "0x60F8CF0", VA = "0x1860FA0F0")]
	public void KBPDEGGFOIC(IJFKDKOGPNP MAEGJLGHFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
	public void NJNJIFBLMNK(int APNFMDEKIKD, EMMGIBGHALO KLFIBHOCAIE, int KOKOMCHJGFE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x60FA210", Offset = "0x60F8E10", VA = "0x1860FA210")]
	public void MAEOBELKBFO(List<byte> ANBIGHEODDA, Vector3 GMKEEAOHFFK, float KOJGOKMBBJK, float EMPBHPEFJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x60FA470", Offset = "0x60F9070", VA = "0x1860FA470")]
	public bool MOOPFBLHJNI(Vector3 HBOOGDGOIKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x60FA4A0", Offset = "0x60F90A0", VA = "0x1860FA4A0")]
	public bool OKPKBEMLEMP(Vector3 HBOOGDGOIKL, float KGBEKPLMINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x60FA060", Offset = "0x60F8C60", VA = "0x1860FA060")]
	public void HAJAGMDCLHL()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct OPBOPHPJKKK<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private readonly List<Component> GPOHBJENHCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private readonly bool DKCCFOEACGK;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x3BF5770", Offset = "0x3BF4370", VA = "0x183BF5770")]
			public OPBOPHPJKKK(List<Component> GPOHBJENHCE, bool DKCCFOEACGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x403E250", Offset = "0x403CE50", VA = "0x18403E250")]
			public NJMEGNHCING<T> EABNIEGMBCK()
			{
				return default(NJMEGNHCING<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x403E2C0", Offset = "0x403CEC0", VA = "0x18403E2C0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x403E2C0", Offset = "0x403CEC0", VA = "0x18403E2C0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public struct NJMEGNHCING<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private readonly List<Component> GPOHBJENHCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			private readonly bool DKCCFOEACGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private int PMIDLPOCCEE;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public T DDCJPGOIIOH
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0x3F33750", Offset = "0x3F32350", VA = "0x183F33750", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0x3F336E0", Offset = "0x3F322E0", VA = "0x183F336E0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x3F33720", Offset = "0x3F32320", VA = "0x183F33720")]
			public NJMEGNHCING(List<Component> GPOHBJENHCE, bool DKCCFOEACGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x3F33620", Offset = "0x3F32220", VA = "0x183F33620", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x3F33630", Offset = "0x3F32230", VA = "0x183F33630", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x3398820", Offset = "0x3397420", VA = "0x183398820", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x60FCE30", Offset = "0x60FBA30", VA = "0x1860FCE30")]
		private void HAJAGMDCLHL(GameObject CGIBAHKDHNL, bool FAAGKOCIKOI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x60FCFA0", Offset = "0x60FBBA0", VA = "0x1860FCFA0")]
		public static void HAJAGMDCLHL(GameObject CGIBAHKDHNL, ToolHierarchyCache MKCCPGLPKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2A90650", Offset = "0x2A8F250", VA = "0x182A90650")]
		public void KNDLGJEMHBM<T>(Action<T> ODKDNEPMNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2A90870", Offset = "0x2A8F470", VA = "0x182A90870")]
		public T PFCBNCCFNPN<T>(bool DKCCFOEACGK = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2A90590", Offset = "0x2A8F190", VA = "0x182A90590")]
		public OPBOPHPJKKK<T> IPOMLAPMCHC<T>(bool DKCCFOEACGK = false) where T : class
		{
			return default(OPBOPHPJKKK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x60FD160", Offset = "0x60FBD60", VA = "0x1860FD160")]
		public List<Component> JILKICJHOAP(Type CJEAJMFMNNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x60FCD40", Offset = "0x60FB940", VA = "0x1860FCD40", Slot = "4")]
		public bool Equals(ToolHierarchyCache KLNIMOGOBLK, ToolHierarchyCache EGCIDIGPDPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x60FCDC0", Offset = "0x60FB9C0", VA = "0x1860FCDC0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache OGGNGHKHHGI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class LBADFFKPBJG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private int LLHBDBHCNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int JOCAEKINAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private List<T> AHOIOIMGLMJ;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x334CA40", Offset = "0x334B640", VA = "0x18334CA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T DEPMFFDMOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8500", Offset = "0x3BF7100", VA = "0x183BF8500")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public T BOJDCDCNODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8920", Offset = "0x3BF7520", VA = "0x183BF8920")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T FEHEGDOGLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3BF8480", Offset = "0x3BF7080", VA = "0x183BF8480")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3BF8AB0", Offset = "0x3BF76B0", VA = "0x183BF8AB0")]
	public LBADFFKPBJG(int LLHBDBHCNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3BF8760", Offset = "0x3BF7360", VA = "0x183BF8760")]
	public void BGJHDHHBMPP(T OCODIPKECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3BF8990", Offset = "0x3BF7590", VA = "0x183BF8990")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF89E0", Offset = "0x3BF75E0", VA = "0x183BF89E0")]
	public void JDCAOBPOHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x3BF8860", Offset = "0x3BF7460", VA = "0x183BF8860")]
	public void FFEJMMEEDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3BF89D0", Offset = "0x3BF75D0", VA = "0x183BF89D0")]
	public void ILJFCJKLHMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class ABPABPJJIFH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private struct MBKDKBOMAMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public int FBIPALDFKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public T BLAEOCKJGCA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Dictionary<object, MBKDKBOMAMF> MCNKNEKLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly EqualityComparer<T> ACNOFJNAJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private T IKHFJCHDOBM;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public virtual T KDOCDKIKNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x107D790", Offset = "0x107C390", VA = "0x18107D790", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3732ED0", Offset = "0x3731AD0", VA = "0x183732ED0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool PBAODPJKGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3733A00", Offset = "0x3732600", VA = "0x183733A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public object FMMLGPCBKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3733100", Offset = "0x3731D00", VA = "0x183733100")]
	public bool KMCELLHAPCK(T BLKAHBIJBJO, object DGPOLLDAHJK, int JKKEGEHBAJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x3732F20", Offset = "0x3731B20", VA = "0x183732F20")]
	public bool GJCMIPAODGB(object DGPOLLDAHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x3733FD0", Offset = "0x3732BD0", VA = "0x183733FD0")]
	public bool PODAMIMAFNE(object DGPOLLDAHJK, [Out] T BLKAHBIJBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x3732EF0", Offset = "0x3731AF0", VA = "0x183732EF0")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3731190", Offset = "0x372FD90", VA = "0x183731190")]
	private bool BBBPHPEHGPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x37342B0", Offset = "0x3732EB0", VA = "0x1837342B0")]
	public ABPABPJJIFH()
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
