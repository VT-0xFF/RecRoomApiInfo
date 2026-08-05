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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D8CF80", Offset = "0x7D8BB80", VA = "0x187D8CF80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AGGNHFCEGIJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x220C420", Offset = "0x220B020", VA = "0x18220C420")]
	public AGGNHFCEGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, BKEFHDBHPEK, LODEFEDJPHP, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash COEHPKCLNDD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xC51910", Offset = "0xC50510", VA = "0x180C51910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D8F2F0", Offset = "0x7D8DEF0", VA = "0x187D8F2F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F2B0", Offset = "0x7D8DEB0", VA = "0x187D8F2B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F330", Offset = "0x7D8DF30", VA = "0x187D8F330")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F4E0", Offset = "0x7D8E0E0", VA = "0x187D8F4E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F450", Offset = "0x7D8E050", VA = "0x187D8F450")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA70670", Offset = "0xA6F270", VA = "0x180A70670")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA70940", Offset = "0xA6F540", VA = "0x180A70940")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F270", Offset = "0x7D8DE70", VA = "0x187D8F270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F3C0", Offset = "0x7D8DFC0", VA = "0x187D8F3C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D8ED10", Offset = "0x7D8D910", VA = "0x187D8ED10")]
	public void CopyBounds(SavedExtents GMNGNCHKEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F1C0", Offset = "0x7D8DDC0", VA = "0x187D8F1C0")]
	public void SetLocalSpaceBounds(Bounds EJCOGPMGADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x157E5F0", Offset = "0x157D1F0", VA = "0x18157E5F0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F000", Offset = "0x7D8DC00", VA = "0x187D8F000")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F010", Offset = "0x7D8DC10", VA = "0x187D8F010")]
	private void PEOFBAAJJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D8EE00", Offset = "0x7D8DA00", VA = "0x187D8EE00")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E6D0", Offset = "0x7D8D2D0", VA = "0x187D8E6D0")]
	public static void CalculateLocalBoundsFor(GameObject AOALCMHDOFP, [Out] Bounds EJCOGPMGADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D8ED40", Offset = "0x7D8D940", VA = "0x187D8ED40")]
	private static void NBILDGBHECA(Bounds KLKIJPOLHDE, Color OFHHGNENJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D8F1E0", Offset = "0x7D8DDE0", VA = "0x187D8F1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA20EC0", Offset = "0xA1FAC0", VA = "0x180A20EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1A59990", Offset = "0x1A58590", VA = "0x181A59990")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x59FAEC0", Offset = "0x59F9AC0", VA = "0x1859FAEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public virtual void DLIDEHOMAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
	[AGGNHFCEGIJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x59FAAF0", Offset = "0x59F96F0", VA = "0x1859FAAF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x59F9940", Offset = "0x59F8540", VA = "0x1859F9940", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x59FAE20", Offset = "0x59F9A20", VA = "0x1859FAE20")]
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
	private sealed class JOBBOLFCBHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JOBBOLFCBHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5111E70", Offset = "0x5110A70", VA = "0x185111E70")]
		internal int IMMADPCIGCF(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[AGGNHFCEGIJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4756BC0", Offset = "0x47557C0", VA = "0x184756BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4756C00", Offset = "0x4755800", VA = "0x184756C00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4756AE0", Offset = "0x47556E0", VA = "0x184756AE0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MEPFFFGIFGB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4756B60", Offset = "0x4755760", VA = "0x184756B60", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x47569E0", Offset = "0x47555E0", VA = "0x1847569E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4756700", Offset = "0x4755300", VA = "0x184756700", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4755BF0", Offset = "0x47547F0", VA = "0x184755BF0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4755AE0", Offset = "0x47546E0", VA = "0x184755AE0", Slot = "14")]
	protected virtual string COKAPFIFNAK(TKeyVal IFNMAHCBHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4755B10", Offset = "0x4754710", VA = "0x184755B10", Slot = "4")]
	public bool ContainsKey(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x47568B0", Offset = "0x47554B0", VA = "0x1847568B0", Slot = "5")]
	public bool TryGetValue(TKey MEPFFFGIFGB, [Out] TVal OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4755B50", Offset = "0x4754750", VA = "0x184755B50", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4755B50", Offset = "0x4754750", VA = "0x184755B50", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47568F0", Offset = "0x47554F0", VA = "0x1847568F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x42D10A0", Offset = "0x42CFCA0", VA = "0x1842D10A0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[AGGNHFCEGIJ]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x59FC560", Offset = "0x59FB160", VA = "0x1859FC560")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x59FBEB0", Offset = "0x59FAAB0", VA = "0x1859FBEB0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x59FB530", Offset = "0x59FA130", VA = "0x1859FB530", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class GODONLACFGP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct KJNGKLCKJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T IOOEMCNJEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float AMFDDLCPOOJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int EDDPIFNJKBP = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float NPPLLEOHLOI = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly KJNGKLCKJLD[] IKALPCJBCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int MPKANDBCNDK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float NIOGMIOCADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xCBD280", Offset = "0xCBBE80", VA = "0x180CBD280")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD02870", Offset = "0xD01470", VA = "0x180D02870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T NBAJEEHPNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D33A80", Offset = "0x4D32680", VA = "0x184D33A80")]
	protected GODONLACFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4D33A00", Offset = "0x4D32600", VA = "0x184D33A00")]
	protected GODONLACFGP(int DKFJGBGJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D33920", Offset = "0x4D32520", VA = "0x184D33920")]
	public void NKAMMCABBBC(float COICELPPBEA, T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool BHMAEJPGNEF(float FJMHMJLNBID, float HNHNPOGDJMJ, [Out] T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool MCFDFLJCODA(float FJMHMJLNBID, float HNHNPOGDJMJ, [Out] T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4D337E0", Offset = "0x4D323E0", VA = "0x184D337E0")]
	public void ILJKHADAMOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ELEPIIFDMHG : GODONLACFGP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B8D0", Offset = "0x7D8A4D0", VA = "0x187D8B8D0", Slot = "4")]
	public override bool BHMAEJPGNEF(float FJMHMJLNBID, float HNHNPOGDJMJ, [Out] Vector3 OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BA30", Offset = "0x7D8A630", VA = "0x187D8BA30", Slot = "5")]
	public override bool MCFDFLJCODA(float FJMHMJLNBID, float HNHNPOGDJMJ, [Out] Vector3 OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BB70", Offset = "0x7D8A770", VA = "0x187D8BB70")]
	public ELEPIIFDMHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IJDOIJACBCC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0C60", Offset = "0x3AEF860", VA = "0x183AF0C60")]
	public static MOCPDNLEKIK<T1, T2> GLOMJONEBBE<T1, T2>(T1 PICIFGHBFON, T2 ILKFLOMBJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0CE0", Offset = "0x3AEF8E0", VA = "0x183AF0CE0")]
	public static OIDIOJCCILK<T1, T2, T3> GLOMJONEBBE<T1, T2, T3>(T1 PICIFGHBFON, T2 ILKFLOMBJNH, T3 OBLNLPEFKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x55068E0", Offset = "0x55054E0", VA = "0x1855068E0")]
	internal static int FEGLHFIOHOH(int MKBKKAPLFPO, int HLEKDNLMKFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F544A0", Offset = "0x6F530A0", VA = "0x186F544A0")]
	internal static int FEGLHFIOHOH(int MKBKKAPLFPO, int HLEKDNLMKFO, int MINLFPJMHCP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MOCPDNLEKIK<T1, T2> : IComparable<MOCPDNLEKIK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 HFMJAKKLHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 OIAGMECFJPB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x54D4ED0", Offset = "0x54D3AD0", VA = "0x1854D4ED0")]
	public MOCPDNLEKIK(T1 PICIFGHBFON, T2 ILKFLOMBJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x54D32F0", Offset = "0x54D1EF0", VA = "0x1854D32F0", Slot = "4")]
	public int CompareTo(MOCPDNLEKIK<T1, T2> GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x54D3F30", Offset = "0x54D2B30", VA = "0x1854D3F30", Slot = "0")]
	public override bool Equals(object GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x54D42E0", Offset = "0x54D2EE0", VA = "0x1854D42E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x54D4950", Offset = "0x54D3550", VA = "0x1854D4950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OIDIOJCCILK<T1, T2, T3> : IComparable<OIDIOJCCILK<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 HFMJAKKLHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 OIAGMECFJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 FFCHFKDKMCG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x566A020", Offset = "0x5668C20", VA = "0x18566A020")]
	public OIDIOJCCILK(T1 PICIFGHBFON, T2 ILKFLOMBJNH, T3 OBLNLPEFKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5669700", Offset = "0x5668300", VA = "0x185669700", Slot = "4")]
	public int CompareTo(OIDIOJCCILK<T1, T2, T3> GMNGNCHKEBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5669960", Offset = "0x5668560", VA = "0x185669960", Slot = "0")]
	public override bool Equals(object GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5669C30", Offset = "0x5668830", VA = "0x185669C30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5669D60", Offset = "0x5668960", VA = "0x185669D60", Slot = "3")]
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
	public AnimationCurve KDNJINJFENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T MHAMLLKJKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x12E9310", Offset = "0x12E7F10", VA = "0x1812E9310")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T PNCAECIAOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCADF90", Offset = "0xCACB90", VA = "0x180CADF90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D467C0", Offset = "0x2D453C0", VA = "0x182D467C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2D46930", Offset = "0x2D45530", VA = "0x182D46930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float LAELKKACMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA6F5C0", Offset = "0xA6E1C0", VA = "0x180A6F5C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CA5EB0", Offset = "0x5CA4AB0", VA = "0x185CA5EB0")]
	public T NPFJFMOGONG(float LPCHKKFEGJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CA6250", Offset = "0x5CA4E50", VA = "0x185CA6250")]
	public T OHHBLDGDINK(float LPCHKKFEGJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CDIOBDIIBMB(T HLPEBKMLKLE, T MAELALMKOEM, float LPCHKKFEGJO);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BF50", Offset = "0x7D8AB50", VA = "0x187D8BF50", Slot = "4")]
	protected override float CDIOBDIIBMB(float HLPEBKMLKLE, float MAELALMKOEM, float LPCHKKFEGJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BF90", Offset = "0x7D8AB90", VA = "0x187D8BF90")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x18AA100", Offset = "0x18A8D00", VA = "0x1818AA100", Slot = "4")]
	protected override Vector3 CDIOBDIIBMB(Vector3 HLPEBKMLKLE, Vector3 MAELALMKOEM, float LPCHKKFEGJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7D902B0", Offset = "0x7D8EEB0", VA = "0x187D902B0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B760", Offset = "0x7D8A360", VA = "0x187D8B760", Slot = "4")]
	protected override Color CDIOBDIIBMB(Color HLPEBKMLKLE, Color MAELALMKOEM, float LPCHKKFEGJO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B820", Offset = "0x7D8A420", VA = "0x187D8B820")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FPDIPPGMAIC : JJKOBPAHFMF<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BF00", Offset = "0x7D8AB00", VA = "0x187D8BF00")]
	public FPDIPPGMAIC(int PDJAEHLNOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BE90", Offset = "0x7D8AA90", VA = "0x187D8BE90", Slot = "6")]
	protected override uint DCMOHFPMDID(uint COEHPKCLNDD, string OOHGFGHCOAJ)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DCPHDOANGEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable LBPNLDGACAA;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public DCPHDOANGEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct IEHFJCAKMFB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PJNHKNMAGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int CFEHJNLGPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int KHHJHNJIHAB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C100", Offset = "0x4E6AD00", VA = "0x184E6C100")]
	private IEHFJCAKMFB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BFCOBHEFHHH, int PGJOCOADLPJ, int NFHIONLLLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E6C010", Offset = "0x4E6AC10", VA = "0x184E6C010")]
	public static IEHFJCAKMFB<T> JHMOIFLKJAD()
	{
		return default(IEHFJCAKMFB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E6B310", Offset = "0x4E69F10", VA = "0x184E6B310")]
	public (int, int, Task<T>) IKAMIALNNDH(int KJIKHIJJPOK, [Optional] CancellationToken DKKNFNCKCEB, double KLCDLOHEBCJ = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4E6A2C0", Offset = "0x4E68EC0", VA = "0x184E6A2C0")]
	public void HPFGNPMDPIA(int KJIKHIJJPOK, int NFHIONLLLPO, [In] T DBJBIPJCIKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class FOMDNONEHHK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BE40", Offset = "0x7D8AA40", VA = "0x187D8BE40")]
	public static IEHFJCAKMFB<BOFEABKGBFC> JHMOIFLKJAD()
	{
		return default(IEHFJCAKMFB<BOFEABKGBFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BDC0", Offset = "0x7D8A9C0", VA = "0x187D8BDC0")]
	public static void HPFGNPMDPIA([In] this IEHFJCAKMFB<BOFEABKGBFC> LAAPKLDJLPE, int KJIKHIJJPOK, int NFHIONLLLPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class INGCHEDHPMH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> EBKCNBJFGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> DFOCDJKCOMJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x428CDB0", Offset = "0x428B9B0", VA = "0x18428CDB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KKNAEFNJMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> PJAGCIOFNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4717900", Offset = "0x4716500", VA = "0x184717900", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> LJCBAOPLEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4E82EA0", Offset = "0x4E81AA0", VA = "0x184E82EA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4E82E40", Offset = "0x4E81A40", VA = "0x184E82E40", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4E82F00", Offset = "0x4E81B00", VA = "0x184E82F00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4E82740", Offset = "0x4E81340", VA = "0x184E82740")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E824B0", Offset = "0x4E810B0", VA = "0x184E824B0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4E82C30", Offset = "0x4E81830", VA = "0x184E82C30", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4E82410", Offset = "0x4E81010", VA = "0x184E82410", Slot = "9")]
	public void Add(TKey MEPFFFGIFGB, TVal OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4E82460", Offset = "0x4E81060", VA = "0x184E82460", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4E82510", Offset = "0x4E81110", VA = "0x184E82510", Slot = "8")]
	public bool ContainsKey(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E82550", Offset = "0x4E81150", VA = "0x184E82550", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E82BB0", Offset = "0x4E817B0", VA = "0x184E82BB0", Slot = "10")]
	public bool Remove(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E82BD0", Offset = "0x4E817D0", VA = "0x184E82BD0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E82CD0", Offset = "0x4E818D0", VA = "0x184E82CD0", Slot = "11")]
	public bool TryGetValue(TKey MEPFFFGIFGB, [Out] TVal OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4E826B0", Offset = "0x4E812B0", VA = "0x184E826B0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4E825B0", Offset = "0x4E811B0", VA = "0x184E825B0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IKALPCJBCLK, int CEPNAODLCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4E82620", Offset = "0x4E81220", VA = "0x184E82620")]
	public bool GFPOIIGIKGC(TVal MEPFFFGIFGB, [Out] TKey OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4E82970", Offset = "0x4E81570", VA = "0x184E82970")]
	private void MDLFFALNMBH(TKey MEPFFFGIFGB, TVal AGKJLFOJIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4E827D0", Offset = "0x4E813D0", VA = "0x184E827D0")]
	private void JMEOCHJIHLP(TKey MEPFFFGIFGB, TVal AGKJLFOJIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4E82AE0", Offset = "0x4E816E0", VA = "0x184E82AE0")]
	private bool PMIGKCFKJGL(TKey MEPFFFGIFGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4E82D10", Offset = "0x4E81910", VA = "0x184E82D10")]
	public INGCHEDHPMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class OAMCFEMDCHD<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private OAMCFEMDCHD<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x47AAD60", Offset = "0x47A9960", VA = "0x1847AAD60", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x47BA940", Offset = "0x47B9540", VA = "0x1847BA940", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x47BADE0", Offset = "0x47B99E0", VA = "0x1847BADE0")]
		public Enumerator(OAMCFEMDCHD<T> DPMBBHPEMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x47B93C0", Offset = "0x47B7FC0", VA = "0x1847B93C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x47B9CC0", Offset = "0x47B88C0", VA = "0x1847B9CC0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x47B9340", Offset = "0x47B7F40", VA = "0x1847B9340")]
		private void FEHFIFIPEMF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] CAPOGHJBIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int DPCFFPEBOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int AELGPLKDFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int JBMEHOAGBAN;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x56522B0", Offset = "0x5650EB0", VA = "0x1856522B0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x564FDB0", Offset = "0x564E9B0", VA = "0x18564FDB0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x564FB80", Offset = "0x564E780", VA = "0x18564FB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5652230", Offset = "0x5650E30", VA = "0x185652230")]
	public OAMCFEMDCHD(int PDJAEHLNOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x56500D0", Offset = "0x564ECD0", VA = "0x1856500D0")]
	public void NKAMMCABBBC(T LPCHKKFEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5650500", Offset = "0x564F100", VA = "0x185650500")]
	public void PAFOMKPENGA(IEnumerable<T> BNCKDCNKIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x564FED0", Offset = "0x564EAD0", VA = "0x18564FED0")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5651EB0", Offset = "0x5650AB0", VA = "0x185651EB0")]
	public void PPDMPCCOEEI(int DPOOEAFKIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x564F4F0", Offset = "0x564E0F0", VA = "0x18564F4F0")]
	public void BMGNJMMNIBI(T[] IKALPCJBCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x564FEF0", Offset = "0x564EAF0", VA = "0x18564FEF0")]
	public Enumerator MEEEBEDBKAB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5652050", Offset = "0x5650C50", VA = "0x185652050", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5652050", Offset = "0x5650C50", VA = "0x185652050", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5651AB0", Offset = "0x56506B0", VA = "0x185651AB0")]
	private int PBIEMEMHPLL(int EMMACFPOKFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x564FC20", Offset = "0x564E820", VA = "0x18564FC20")]
	private int GLHPJCKJOFL(int EMMACFPOKFB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DNLOAJMEGJK<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> IIBBBEJLJBN(TRequest BJAGJMJPKHA, CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum CEHDJJDGKFG
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class DPPOLFMDCGA
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float AAHHHCDPMCA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan DKCIIBILEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int CKKBNAOFEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CEHDJJDGKFG AMEMKOEJBHH;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly DPPOLFMDCGA DIACPKGMELN;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float PEAEHOPJNGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x42E2330", Offset = "0x42E0F30", VA = "0x1842E2330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan OGJJICJNANP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x42E23A0", Offset = "0x42E0FA0", VA = "0x1842E23A0")]
		public DPPOLFMDCGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct DAEKNBNJNLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest BJAGJMJPKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken DKKNFNCKCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> GDDLEADELHG;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6B7D810", Offset = "0x6B7C410", VA = "0x186B7D810")]
		public DAEKNBNJNLH(TRequest BJAGJMJPKHA, TaskCompletionSource<TResult> GDDLEADELHG, CancellationToken DKKNFNCKCEB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct FFLHKFBBEHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public DNLOAJMEGJK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4C0BE90", Offset = "0x4C0AA90", VA = "0x184C0BE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C0C6D0", Offset = "0x4C0B2D0", VA = "0x184C0C6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct EBHAEPNBBIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public DNLOAJMEGJK<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private DAEKNBNJNLH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x470BB40", Offset = "0x470A740", VA = "0x18470BB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x470C6C0", Offset = "0x470B2C0", VA = "0x18470C6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource FCONFBINOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<DAEKNBNJNLH> BBAEEDMEPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly DPPOLFMDCGA CHCPHGKLGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IIBBBEJLJBN OIJJLEDKCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task BDAHBMBKIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int PIJNHEBMOLK;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x42D0BE0", Offset = "0x42CF7E0", VA = "0x1842D0BE0")]
	public DNLOAJMEGJK(IIBBBEJLJBN OIJJLEDKCEC, [Optional] DPPOLFMDCGA CHCPHGKLGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x42D0A00", Offset = "0x42CF600", VA = "0x1842D0A00")]
	public Task<TResult> PNGEMEHLLEF(TRequest BJAGJMJPKHA, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x42CF590", Offset = "0x42CE190", VA = "0x1842CF590")]
	private void CLJGHECPCDK(DAEKNBNJNLH LMMELIHNEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x42D0520", Offset = "0x42CF120", VA = "0x1842D0520")]
	[AsyncStateMachine(typeof(DNLOAJMEGJK<, >.FFLHKFBBEHI))]
	private Task NGBJCGFIMKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x42CFBC0", Offset = "0x42CE7C0", VA = "0x1842CFBC0")]
	private DAEKNBNJNLH JOCMGHBDKNL()
	{
		return default(DAEKNBNJNLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x42D0290", Offset = "0x42CEE90", VA = "0x1842D0290")]
	[AsyncStateMachine(typeof(DNLOAJMEGJK<, >.EBHAEPNBBIC))]
	private Task KHPEIFPDHIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x42CF750", Offset = "0x42CE350", VA = "0x1842CF750")]
	private void HKDFHGLLMMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x42CF620", Offset = "0x42CE220", VA = "0x1842CF620", Slot = "4")]
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
public class OMPKMCMNOHP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> DNNGKIFFAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> IIAPAMIBPEA;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x428CDB0", Offset = "0x428B9B0", VA = "0x18428CDB0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KKNAEFNJMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DB6330", Offset = "0x4DB4F30", VA = "0x184DB6330", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5693EE0", Offset = "0x5692AE0", VA = "0x185693EE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4C6F400", Offset = "0x4C6E000", VA = "0x184C6F400", Slot = "11")]
	public void Add(T ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5693A60", Offset = "0x5692660", VA = "0x185693A60")]
	public bool OFIPOAPPKAI(T ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5693D60", Offset = "0x5692960", VA = "0x185693D60", Slot = "15")]
	public bool Remove(T ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x429E9F0", Offset = "0x429D5F0", VA = "0x18429E9F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4CBAF90", Offset = "0x4CB9B90", VA = "0x184CBAF90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5693740", Offset = "0x5692340", VA = "0x185693740", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x56937A0", Offset = "0x56923A0", VA = "0x1856937A0", Slot = "13")]
	public bool Contains(T ONKLOOMCJOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x56937E0", Offset = "0x56923E0", VA = "0x1856937E0", Slot = "14")]
	public void CopyTo(T[] IKALPCJBCLK, int CEPNAODLCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5252610", Offset = "0x5251210", VA = "0x185252610", Slot = "6")]
	public int IndexOf(T ONKLOOMCJOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5693810", Offset = "0x5692410", VA = "0x185693810", Slot = "7")]
	public void Insert(int EMMACFPOKFB, T ONKLOOMCJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5693B10", Offset = "0x5692710", VA = "0x185693B10", Slot = "8")]
	public void RemoveAt(int EMMACFPOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5693DF0", Offset = "0x56929F0", VA = "0x185693DF0")]
	public OMPKMCMNOHP()
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
			[Cpp2IlInjected.Address(RVA = "0x2BA11E0", Offset = "0x2B9FDE0", VA = "0x182BA11E0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA7BC00", Offset = "0xA7A800", VA = "0x180A7BC00")]
		public SerializedGuid([In] Guid LHECJJHBNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F6F0", Offset = "0x7D8E2F0", VA = "0x187D8F6F0")]
		public static SerializedGuid IMGDCIJGLFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F570", Offset = "0x7D8E170", VA = "0x187D8F570")]
		public static SerializedGuid CGFPOODOHJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F820", Offset = "0x7D8E420", VA = "0x187D8F820")]
		public bool PNOGDJAFBNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F7F0", Offset = "0x7D8E3F0", VA = "0x187D8F7F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F770", Offset = "0x7D8E370", VA = "0x187D8F770", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F610", Offset = "0x7D8E210", VA = "0x187D8F610", Slot = "7")]
		public bool Equals(SerializedGuid GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F650", Offset = "0x7D8E250", VA = "0x187D8F650", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F6E0", Offset = "0x7D8E2E0", VA = "0x187D8F6E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F5E0", Offset = "0x7D8E1E0", VA = "0x187D8F5E0", Slot = "6")]
		public int CompareTo(SerializedGuid GMNGNCHKEBK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KJEFLAEJLAB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type IDFLNGMLJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string JHPICMKOLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool NAIOCHGODCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool JPHHCBFKIJK;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C4B0", Offset = "0x7D8B0B0", VA = "0x187D8C4B0")]
	public KJEFLAEJLAB(Type JMCGNNJCKEM, string KCNEHEMHKAA, bool ILFIMCFKDCD = false, bool JMKHNKIOBAG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MEMCANBDGEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int ECNAIPALPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> FBBDHJHNEIO(float COICELPPBEA, [Optional] float? NGHLDCFFPEB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGDNCPAGDIH(float COICELPPBEA, T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILJKHADAMOK();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class GJNBFPMLHNG<T> : MEMCANBDGEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class LDHKGFMIPMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float DOCMGEGHDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T IOOEMCNJEAH;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LDHKGFMIPMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GOFFENNFKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GOFFENNFKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4D33AA0", Offset = "0x4D326A0", VA = "0x184D33AA0")]
		internal bool AJDJGMDLDOM(LDHKGFMIPMM sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float DACEGHDHMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float OIHALEBJJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<LDHKGFMIPMM> PGJFDNPDJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private DJJGMNBJIKA<LDHKGFMIPMM> HBIDAIIPPPH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int ECNAIPALPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4D15EE0", Offset = "0x4D14AE0", VA = "0x184D15EE0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D169F0", Offset = "0x4D155F0", VA = "0x184D169F0")]
	public GJNBFPMLHNG(float DOOJGHIGPND, float CALLBBIIPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D165E0", Offset = "0x4D151E0", VA = "0x184D165E0", Slot = "6")]
	public bool KGDNCPAGDIH(float COICELPPBEA, T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D15FC0", Offset = "0x4D14BC0", VA = "0x184D15FC0", Slot = "5")]
	public IEnumerable<T> FBBDHJHNEIO(float COICELPPBEA, float? NGHLDCFFPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D16580", Offset = "0x4D15180", VA = "0x184D16580", Slot = "7")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D168B0", Offset = "0x4D154B0", VA = "0x184D168B0")]
	private void OJFOGHNFAII(float COICELPPBEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class KEEDMGNKBDL<T> : MEMCANBDGEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct HEMGPMIALOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T IOOEMCNJEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float DOCMGEGHDBD;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E0A0", Offset = "0x4D8CCA0", VA = "0x184D8E0A0")]
		public HEMGPMIALOL(T OOHGFGHCOAJ, float COICELPPBEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class PMMDGHGGMLN : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public KEEDMGNKBDL<T> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public PMMDGHGGMLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x57E4160", Offset = "0x57E2D60", VA = "0x1857E4160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x57E44D0", Offset = "0x57E30D0", VA = "0x1857E44D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x57E4300", Offset = "0x57E2F00", VA = "0x1857E4300", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4CEABB0", Offset = "0x4CE97B0", VA = "0x184CEABB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float DOOJGHIGPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float CALLBBIIPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<HEMGPMIALOL> PGJFDNPDJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int DPCFFPEBOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int FPOCJIPKHGP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int ECNAIPALPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA20E70", Offset = "0xA1FA70", VA = "0x180A20E70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x51D7810", Offset = "0x51D6410", VA = "0x1851D7810")]
	public KEEDMGNKBDL(float DOOJGHIGPND, float CALLBBIIPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x51D7410", Offset = "0x51D6010", VA = "0x1851D7410", Slot = "6")]
	public bool KGDNCPAGDIH(float COICELPPBEA, T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x51D7650", Offset = "0x51D6250", VA = "0x1851D7650", Slot = "8")]
	public int LAABOLCNHBB(float COICELPPBEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x51D7040", Offset = "0x51D5C40", VA = "0x1851D7040", Slot = "5")]
	[IteratorStateMachine(typeof(KEEDMGNKBDL<>.PMMDGHGGMLN))]
	public IEnumerable<T> FBBDHJHNEIO(float COICELPPBEA, float? NGHLDCFFPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x51D71A0", Offset = "0x51D5DA0", VA = "0x1851D71A0", Slot = "7")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x51D7740", Offset = "0x51D6340", VA = "0x1851D7740")]
	private void PJFOCOOIKAL(float COICELPPBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x51D6EF0", Offset = "0x51D5AF0", VA = "0x1851D6EF0")]
	private HEMGPMIALOL COCGBNHPOIC()
	{
		return default(HEMGPMIALOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class HMEJDNPIBLC<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct JLEPFPICBDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long JGLEIKHFJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long HEHKFMAEJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int LBIOGMGANOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int HGHKHHPKMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool PCEBBJLJKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string IIGNHDFGFCK;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x510E820", Offset = "0x510D420", VA = "0x18510E820")]
		public JLEPFPICBDD(long JGLEIKHFJJF, int LBIOGMGANOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x510E7F0", Offset = "0x510D3F0", VA = "0x18510E7F0")]
		public JLEPFPICBDD(long JGLEIKHFJJF, long HEHKFMAEJPB, int LBIOGMGANOJ, int HGHKHHPKMAM, bool PCEBBJLJKAK, string IIGNHDFGFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x510E740", Offset = "0x510D340", VA = "0x18510E740")]
		public int KOBEEHABHCB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x510E680", Offset = "0x510D280", VA = "0x18510E680")]
		public int DFENNJEBLDE(int MHHLAPEBNJC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x510E790", Offset = "0x510D390", VA = "0x18510E790")]
		public double PIIFJOIMEIP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x510E6A0", Offset = "0x510D2A0", VA = "0x18510E6A0")]
		public JLEPFPICBDD EDCFBDHEJFG(long HEHKFMAEJPB, int HGHKHHPKMAM)
		{
			return default(JLEPFPICBDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class FIEDNALJEDE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct LNNHGMDCIIK<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public FIEDNALJEDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<FIEDNALJEDE, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private FIEDNALJEDE <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x52CE560", Offset = "0x52CD160", VA = "0x1852CE560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x471DDA0", Offset = "0x471C9A0", VA = "0x18471DDA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey JOMDPKHKCFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly HMEJDNPIBLC<TKey> KDCDPEHJICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly JPIBGNDAFKP FAOMHPPHFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<FIEDNALJEDE> HKLIPMAOOGG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string IENBBBKOJAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4C12110", Offset = "0x4C10D10", VA = "0x184C12110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<FIEDNALJEDE> JCKAMMHMPCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4C12160", Offset = "0x4C10D60", VA = "0x184C12160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public JLEPFPICBDD GIHFJHFNFBF
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x4C12140", Offset = "0x4C10D40", VA = "0x184C12140")]
			[CompilerGenerated]
			get
			{
				return default(JLEPFPICBDD);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4C11DB0", Offset = "0x4C109B0", VA = "0x184C11DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4C12190", Offset = "0x4C10D90", VA = "0x184C12190")]
		internal FIEDNALJEDE(HMEJDNPIBLC<TKey> KDCDPEHJICI, TKey MEPFFFGIFGB, JPIBGNDAFKP FAOMHPPHFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4C11DE0", Offset = "0x4C109E0", VA = "0x184C11DE0")]
		public FIEDNALJEDE BPHIBGINKOP(TKey MEPFFFGIFGB, [Optional] JPIBGNDAFKP? BHEDAECEBHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E1D0", Offset = "0x3C2CDD0", VA = "0x183C2E1D0")]
		[AsyncStateMachine(typeof(LNNHGMDCIIK<>))]
		public Task<T> FPJMCGFJBJE<T>(TKey MEPFFFGIFGB, Func<FIEDNALJEDE, Task<T>> PAGHHLHAGEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4C11F30", Offset = "0x4C10B30", VA = "0x184C11F30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class FMKIKIHIDON : IEnumerable<(TKey, List<TKey>, JLEPFPICBDD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JLEPFPICBDD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, JLEPFPICBDD timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public HMEJDNPIBLC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, JLEPFPICBDD timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, JLEPFPICBDD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2B9AA90", Offset = "0x2B99690", VA = "0x182B9AA90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JLEPFPICBDD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x4C1FDE0", Offset = "0x4C1E9E0", VA = "0x184C1FDE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB80", Offset = "0x2B99780", VA = "0x182B9AB80")]
		[DebuggerHidden]
		public FMKIKIHIDON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x42C4100", Offset = "0x42C2D00", VA = "0x1842C4100", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4C1F950", Offset = "0x4C1E550", VA = "0x184C1F950", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4C1F900", Offset = "0x4C1E500", VA = "0x184C1F900")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FD90", Offset = "0x4C1E990", VA = "0x184C1FD90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4C1FCD0", Offset = "0x4C1E8D0", VA = "0x184C1FCD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JLEPFPICBDD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x42EFFD0", Offset = "0x42EEBD0", VA = "0x1842EFFD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class MIHKKAAMJAM : IEnumerable<(TKey, List<TKey>, JLEPFPICBDD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JLEPFPICBDD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, JLEPFPICBDD timerEntry) <>2__current;

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
		private FIEDNALJEDE timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public FIEDNALJEDE <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HMEJDNPIBLC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<FIEDNALJEDE> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, JLEPFPICBDD timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, JLEPFPICBDD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2B9AA90", Offset = "0x2B99690", VA = "0x182B9AA90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JLEPFPICBDD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x54C0F30", Offset = "0x54BFB30", VA = "0x1854C0F30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB80", Offset = "0x2B99780", VA = "0x182B9AB80")]
		[DebuggerHidden]
		public MIHKKAAMJAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x54C0F90", Offset = "0x54BFB90", VA = "0x1854C0F90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x54C06E0", Offset = "0x54BF2E0", VA = "0x1854C06E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x54C0620", Offset = "0x54BF220", VA = "0x1854C0620")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x54C0680", Offset = "0x54BF280", VA = "0x1854C0680")]
		private void JKFKJAKKDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x54C0EE0", Offset = "0x54BFAE0", VA = "0x1854C0EE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x54C0DD0", Offset = "0x54BF9D0", VA = "0x1854C0DD0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JLEPFPICBDD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x54C0EB0", Offset = "0x54BFAB0", VA = "0x1854C0EB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, JLEPFPICBDD, JPIBGNDAFKP> OHDFJOOFPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, JLEPFPICBDD, JPIBGNDAFKP> HCILJONIFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<HMEJDNPIBLC<TKey>, JPIBGNDAFKP> GAGCHIGMHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly FIEDNALJEDE MAOEAAPMKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool OCBGCPNOEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int JOGABEBIEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch PAJKLLEJEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int LEPJGAJKPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string LIJCDMADAHL;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FIEDNALJEDE PFDMBFGBOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string IENBBBKOJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4DB5F50", Offset = "0x4DB4B50", VA = "0x184DB5F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4DB6030", Offset = "0x4DB4C30", VA = "0x184DB6030")]
	public HMEJDNPIBLC(TKey JOCODLEKMGH, JPIBGNDAFKP FAOMHPPHFKM, [Optional] int? LBIOGMGANOJ, [Optional][CanBeNull] Stopwatch PAJKLLEJEJD, [Optional] Action<TKey, JLEPFPICBDD, JPIBGNDAFKP> OHDFJOOFPAO, [Optional] Action<TKey, JLEPFPICBDD, JPIBGNDAFKP> HCILJONIFDA, [Optional] Action<HMEJDNPIBLC<TKey>, JPIBGNDAFKP> GAGCHIGMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5EC0", Offset = "0x4DB4AC0", VA = "0x184DB5EC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5E30", Offset = "0x4DB4A30", VA = "0x184DB5E30")]
	[IteratorStateMachine(typeof(HMEJDNPIBLC<>.FMKIKIHIDON))]
	public IEnumerable<(TKey, List<TKey>, JLEPFPICBDD)> AKKDNDDOAGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5D60", Offset = "0x4DB4960", VA = "0x184DB5D60")]
	[IteratorStateMachine(typeof(HMEJDNPIBLC<>.MIHKKAAMJAM))]
	private IEnumerable<(TKey, List<TKey>, JLEPFPICBDD)> AKKDNDDOAGE(List<TKey> MCLDNGJMMPC, FIEDNALJEDE MIBJENJEJGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4DB5FB0", Offset = "0x4DB4BB0", VA = "0x184DB5FB0")]
	private (long, int) KIHMBCLMGDB()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class ILDJHLBCHOJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut NAAFCGABPIL(HMEJDNPIBLC<TKey> KDCDPEHJICI);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	protected ILDJHLBCHOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class EJEDEIIMLFA<TKey> : ILDJHLBCHOJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string GELENHIACPF(TKey MEPFFFGIFGB);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4738120", Offset = "0x4736D20", VA = "0x184738120")]
	private static string HDDIGMOFMCH(TKey MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4738160", Offset = "0x4736D60", VA = "0x184738160", Slot = "4")]
	public override string NAAFCGABPIL(HMEJDNPIBLC<TKey> KDCDPEHJICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4738210", Offset = "0x4736E10", VA = "0x184738210")]
	public string NAAFCGABPIL(HMEJDNPIBLC<TKey> KDCDPEHJICI, [NotNull] GELENHIACPF KLFNDHJDPNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string FLGJNCBFABG(HMEJDNPIBLC<TKey> KDCDPEHJICI, [NotNull] GELENHIACPF KLFNDHJDPNL);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x47034F0", Offset = "0x47020F0", VA = "0x1847034F0")]
	protected EJEDEIIMLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class INPJDKEEBBH<TKey> : ILDJHLBCHOJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string ALANGMHEADB(TKey MEPFFFGIFGB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string MFGABFNMKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double AMKCLAKMJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool INCLMJMIPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int IKAIPJICDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> GPEGICEJGKC;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4E84CD0", Offset = "0x4E838D0", VA = "0x184E84CD0")]
	private static string HDDIGMOFMCH(TKey MEPFFFGIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4E857C0", Offset = "0x4E843C0", VA = "0x184E857C0")]
	public INPJDKEEBBH(string MFGABFNMKHG = "F2", double AMKCLAKMJIB = double.MaxValue, bool INCLMJMIPNN = false, int IKAIPJICDKI = int.MaxValue, [Optional] ISet<string> GPEGICEJGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4E85710", Offset = "0x4E84310", VA = "0x184E85710", Slot = "4")]
	public override Dictionary<string, string> NAAFCGABPIL(HMEJDNPIBLC<TKey> KDCDPEHJICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4E84D10", Offset = "0x4E83910", VA = "0x184E84D10")]
	private bool JNLIHBMEEGC(string PLDFJIOPMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4E85160", Offset = "0x4E83D60", VA = "0x184E85160")]
	public Dictionary<string, string> NAAFCGABPIL(HMEJDNPIBLC<TKey> KDCDPEHJICI, ALANGMHEADB KLFNDHJDPNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4E84F50", Offset = "0x4E83B50", VA = "0x184E84F50")]
	private string MHJKINPEMIM(StringBuilder LOAMDJIDMDE, List<TKey> OGCGEBDFHNH, ALANGMHEADB KLFNDHJDPNL, bool MCFLOGOOKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4E84DF0", Offset = "0x4E839F0", VA = "0x184E84DF0")]
	private static void LLKJOBJLAKI(StringBuilder PHHOIMHOGMN, string NKFHNIALKPM, bool GIJEOGKALMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MMMBPBDJMOL<TKey> : EJEDEIIMLFA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct KAOEEMFONAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public GELENHIACPF keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static MMMBPBDJMOL<TKey> LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] MFLGECBKJBK;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x54CC570", Offset = "0x54CB170", VA = "0x1854CC570")]
	private MMMBPBDJMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x54CB550", Offset = "0x54CA150", VA = "0x1854CB550", Slot = "5")]
	protected override string FLGJNCBFABG(HMEJDNPIBLC<TKey> KDCDPEHJICI, GELENHIACPF KLFNDHJDPNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x54CC350", Offset = "0x54CAF50", VA = "0x1854CC350")]
	[CompilerGenerated]
	internal static string PECGHHFKFDC(string MNHJPDPJMLO, TKey MEPFFFGIFGB, KAOEEMFONAF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class EMKBOOENCBM : HMEJDNPIBLC<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KEHBBNIPJNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<EMKBOOENCBM, JPIBGNDAFKP> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KEHBBNIPJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C420", Offset = "0x7D8B020", VA = "0x187D8C420")]
		internal void CCABBNAGKED(HMEJDNPIBLC<string> timer, JPIBGNDAFKP log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BC70", Offset = "0x7D8A870", VA = "0x187D8BC70")]
	public EMKBOOENCBM(JPIBGNDAFKP FAOMHPPHFKM, [Optional] string ELPMNMBFFBE, [Optional] int? LBIOGMGANOJ, [Optional] Stopwatch PAJKLLEJEJD, [Optional] Action<string, JLEPFPICBDD, JPIBGNDAFKP> OHDFJOOFPAO, [Optional] Action<string, JLEPFPICBDD, JPIBGNDAFKP> HCILJONIFDA, [Optional] Action<EMKBOOENCBM, JPIBGNDAFKP> GAGCHIGMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BBB0", Offset = "0x7D8A7B0", VA = "0x187D8BBB0")]
	private static Action<HMEJDNPIBLC<string>, JPIBGNDAFKP> MLMOJKFMIDL(Action<EMKBOOENCBM, JPIBGNDAFKP> LKGGIMHKLEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class CEMFOKNCIBN
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class INHAMCMHHOL : CEMFOKNCIBN
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static CEMFOKNCIBN LBPNLDGACAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7D8C0D0", Offset = "0x7D8ACD0", VA = "0x187D8C0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float AHBHFOBMEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x12880A0", Offset = "0x1286CA0", VA = "0x1812880A0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7D8C1C0", Offset = "0x7D8ADC0", VA = "0x187D8C1C0")]
		public INHAMCMHHOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static CEMFOKNCIBN EBGOPBNLJDF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static CEMFOKNCIBN DIACPKGMELN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7D8B510", Offset = "0x7D8A110", VA = "0x187D8B510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float AHBHFOBMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	protected CEMFOKNCIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface PHBEKKNOPBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool PHEIOPHLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface PHKGFEHMLBA<T> : PHBEKKNOPBH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> EKHNKBGCFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	KLHBLGBFFDH<T> CKLNHIHHAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class MCHEJDDHBLC
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD2F0", Offset = "0x3BABEF0", VA = "0x183BAD2F0")]
	public static PHKGFEHMLBA<TResource> OAEACGAPOJE<TResource, TId>(this BPCCLLICIFH<TId, TResource> AFHEFLCAFIP, TId ALPNKEJICNA, [Optional] Func<TId, CancellationToken, Task<TResource>>? JIJMBHEPKMI) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class BCMMAGIHLPH
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class JPNKOBGAOHP<T> : EAMCAFFIIDI<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> EKHNKBGCFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override KLHBLGBFFDH<T?> CKLNHIHHAHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5118F60", Offset = "0x5117B60", VA = "0x185118F60")]
		public JPNKOBGAOHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "10")]
		protected override void EONHOHOEOKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class MBGOEJJBEPK<T> : EAMCAFFIIDI<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T GPDLKDOPKJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? BEMBLMCHHAA;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> EKHNKBGCFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override KLHBLGBFFDH<T> CKLNHIHHAHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x549B3B0", Offset = "0x5499FB0", VA = "0x18549B3B0")]
		public MBGOEJJBEPK(T MFBFDGPNIHD, Action<T>? MCMBPBIMNPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x549B1E0", Offset = "0x5499DE0", VA = "0x18549B1E0", Slot = "10")]
		protected override void EONHOHOEOKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class EIFHLJLEOPE<T> : EAMCAFFIIDI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> EKHNKBGCFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override KLHBLGBFFDH<T> CKLNHIHHAHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4730C70", Offset = "0x472F870", VA = "0x184730C70")]
		public EIFHLJLEOPE(Exception FCEJBDLGOKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "10")]
		protected override void EONHOHOEOKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class OPGHDHCNJOJ<T> : EAMCAFFIIDI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct MOPOFALMOBD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<PHKGFEHMLBA<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<PHKGFEHMLBA<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x54D7E80", Offset = "0x54D6A80", VA = "0x1854D7E80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x54D8350", Offset = "0x54D6F50", VA = "0x1854D8350", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct EMCHHLJAHEJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<PHKGFEHMLBA<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<PHKGFEHMLBA<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x473A6C0", Offset = "0x47392C0", VA = "0x18473A6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x473A8E0", Offset = "0x47394E0", VA = "0x18473A8E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<PHKGFEHMLBA<T>> IABBJEFPPPH;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> EKHNKBGCFNK
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override KLHBLGBFFDH<T> CKLNHIHHAHE
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x569B140", Offset = "0x5699D40", VA = "0x18569B140")]
		public OPGHDHCNJOJ(Task<PHKGFEHMLBA<T>> NKDMFOKACBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x569AC60", Offset = "0x5699860", VA = "0x18569AC60", Slot = "10")]
		protected override void EONHOHOEOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x569AEA0", Offset = "0x5699AA0", VA = "0x18569AEA0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(OPGHDHCNJOJ<>.MOPOFALMOBD))]
		internal static Task<T> MMPPDOANJFE(Task<PHKGFEHMLBA<T>> NKDMFOKACBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x569ADC0", Offset = "0x56999C0", VA = "0x18569ADC0")]
		[AsyncStateMachine(typeof(OPGHDHCNJOJ<>.EMCHHLJAHEJ))]
		[CompilerGenerated]
		internal static Task LJDEABMHHNG(Task<PHKGFEHMLBA<T>> NKDMFOKACBI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class MIOIMADNMLM<TIn, TOut> : EAMCAFFIIDI<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct LDPIDCKCKIP : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x5283CE0", Offset = "0x52828E0", VA = "0x185283CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x471B480", Offset = "0x471A080", VA = "0x18471B480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly PHKGFEHMLBA<TIn> NGDGMMCBKHI;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> EKHNKBGCFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override KLHBLGBFFDH<TOut> CKLNHIHHAHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x54C1450", Offset = "0x54C0050", VA = "0x1854C1450")]
		public MIOIMADNMLM(PHKGFEHMLBA<TIn> HKFEDFKBDCA, Func<TIn, TOut> LPKLNMLJJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x54C1120", Offset = "0x54BFD20", VA = "0x1854C1120", Slot = "10")]
		protected override void EONHOHOEOKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x54C1170", Offset = "0x54BFD70", VA = "0x1854C1170")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(MIOIMADNMLM<, >.LDPIDCKCKIP))]
		internal static Task<TOut> NKHFAFKMICP(Task<TIn> NFMIFKJOJIN, Func<TIn, TOut> LPKLNMLJJFD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3834200", Offset = "0x3832E00", VA = "0x183834200")]
	public static PHKGFEHMLBA<T> LELJIFADAHI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3834100", Offset = "0x3832D00", VA = "0x183834100")]
	public static PHKGFEHMLBA<T> GHOBBLKKFFF<T>(T DBJBIPJCIKA, [Optional] Action<T>? MCMBPBIMNPF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3834190", Offset = "0x3832D90", VA = "0x183834190")]
	public static PHKGFEHMLBA<T> MHMGCHAKLHN<T>(Exception FCEJBDLGOKN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3834190", Offset = "0x3832D90", VA = "0x183834190")]
	public static PHKGFEHMLBA<T> IPICCNCDILP<T>(Task<PHKGFEHMLBA<T>> NKDMFOKACBI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3834080", Offset = "0x3832C80", VA = "0x183834080")]
	public static PHKGFEHMLBA<TOut> FPIONCNEDML<TOut, TIn>(PHKGFEHMLBA<TIn> BEPAMKMBKNC, Func<TIn, TOut> LPKLNMLJJFD) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class EAMCAFFIIDI<T> : PHKGFEHMLBA<T>, PHBEKKNOPBH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string NNLMCBGMDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly IOPBNOLGHPI JGKHHCAHBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool OCBGCPNOEJE;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool PHEIOPHLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xAA8AC0", Offset = "0xAA76C0", VA = "0x180AA8AC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> EKHNKBGCFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract KLHBLGBFFDH<T> CKLNHIHHAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x470B030", Offset = "0x4709C30", VA = "0x18470B030")]
	public EAMCAFFIIDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x470ACA0", Offset = "0x47098A0", VA = "0x18470ACA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void EONHOHOEOKH();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class NPMGHAEOMBC<TTask, T> : EAMCAFFIIDI<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class JBPGAHOLABB
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
			public JBPGAHOLABB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x42756A0", Offset = "0x42742A0", VA = "0x1842756A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4275BF0", Offset = "0x42747F0", VA = "0x184275BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public NPMGHAEOMBC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JBPGAHOLABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x50AF760", Offset = "0x50AE360", VA = "0x1850AF760")]
		[AsyncStateMachine(typeof(NPMGHAEOMBC<, >.JBPGAHOLABB.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> MLMEBGMAKKH(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> NKDMFOKACBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource MIJBGGNKLIG;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> EKHNKBGCFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override KLHBLGBFFDH<T> CKLNHIHHAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5557230", Offset = "0x5555E30", VA = "0x185557230")]
	protected NPMGHAEOMBC(TTask NKDMFOKACBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x55571E0", Offset = "0x5555DE0", VA = "0x1855571E0", Slot = "10")]
	protected override void EONHOHOEOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T ILJIACAMOOL(TTask LPMOOKPIFIM);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void NKHLLJLLELB();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EKPDHIDEADE<T> : EAMCAFFIIDI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly BDNPFNHIMPF<Task<T>> EMGDALCBLDN;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> EKHNKBGCFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4739070", Offset = "0x4737C70", VA = "0x184739070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override KLHBLGBFFDH<T> CKLNHIHHAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x47390D0", Offset = "0x4737CD0", VA = "0x1847390D0")]
	public EKPDHIDEADE(BDNPFNHIMPF<Task<T>> LLPKHAHHPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x47390B0", Offset = "0x4737CB0", VA = "0x1847390B0", Slot = "10")]
	protected override void EONHOHOEOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MJOFDCMEACB
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName FBDFNEEJPBL;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> ELIMGKOCGGL;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7D8CDB0", Offset = "0x7D8B9B0", VA = "0x187D8CDB0")]
	public static int OBDMIIGGAML(this BKEFHDBHPEK CNCNDENEOMJ, IncrementalHash COEHPKCLNDD, byte[] MAMKKJLFGAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C670", Offset = "0x7D8B270", VA = "0x187D8C670")]
	public static bool HDBOABOPPBE([CanBeNull] this BKEFHDBHPEK CNCNDENEOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7D8CA10", Offset = "0x7D8B610", VA = "0x187D8CA10")]
	public static bool HDBOABOPPBE([CanBeNull] this BKEFHDBHPEK CNCNDENEOMJ, [Out] string AJLIMPCCGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C6D0", Offset = "0x7D8B2D0", VA = "0x187D8C6D0")]
	public static bool HDBOABOPPBE([CanBeNull] this BKEFHDBHPEK CNCNDENEOMJ, IncrementalHash COEHPKCLNDD, byte[] MAMKKJLFGAF, [Out] string AJLIMPCCGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7D8CD20", Offset = "0x7D8B920", VA = "0x187D8CD20")]
	private static bool MPPCMKCBJNE(byte[] HOKHDMPONLN, Span<byte> GCMOIKADMFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MFLFHJHHLKF
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C520", Offset = "0x7D8B120", VA = "0x187D8C520")]
	public static int OGAAPADBMEK(HashAlgorithmName GOEIHEHNMJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB3E80", Offset = "0x3BB2A80", VA = "0x183BB3E80")]
	public static int OBDMIIGGAML<T>(this T MJONKIFINDE, byte[] FNAPLLGJNMI, IncrementalHash COEHPKCLNDD, byte[] KKAFPEIKMHP) where T : LODEFEDJPHP
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LODEFEDJPHP
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash COEHPKCLNDD);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BKEFHDBHPEK : LODEFEDJPHP
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] MHODJKCPPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] EJBNCJPMECG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class PAHKNANPKHL
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool IENIDJPOGCL;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> PAHNGJFJFLP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> CFFFLEHDFCK;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding BHLDLIDEDDA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> BIPHLPOCEHH;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CD60", Offset = "0x3C7B960", VA = "0x183C7CD60")]
	public static void EHAEBGILFPD<T>(this IncrementalHash GBILCLLNGJM, [CanBeNull] T LBEOEMMCAFH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CE20", Offset = "0x3C7BA20", VA = "0x183C7CE20")]
	public static void GNFOMPOCPEF<T>(this IncrementalHash GBILCLLNGJM, [CanBeNull] T MJONKIFINDE) where T : LODEFEDJPHP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3C7DB10", Offset = "0x3C7C710", VA = "0x183C7DB10")]
	public static void NJPILIPFNCJ<T>(this IncrementalHash GBILCLLNGJM, [CanBeNull] IList<T> PAJLICBKKOI) where T : LODEFEDJPHP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7D8DBC0", Offset = "0x7D8C7C0", VA = "0x187D8DBC0")]
	private static bool OHCPKPPHPFC([CanBeNull] LODEFEDJPHP MJONKIFINDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D7C0", Offset = "0x7D8C3C0", VA = "0x187D8D7C0")]
	public static void MMKJCEPJENF(this IncrementalHash COEHPKCLNDD, string? PDAECFLGGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D590", Offset = "0x7D8C190", VA = "0x187D8D590")]
	public static void JMEBOFAAIGH(this IncrementalHash COEHPKCLNDD, long FFHCECGNBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D300", Offset = "0x7D8BF00", VA = "0x187D8D300")]
	public static void EKCOJMOJGOE(this IncrementalHash COEHPKCLNDD, int PJJOCNOBEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7D8DD60", Offset = "0x7D8C960", VA = "0x187D8DD60")]
	public static void OPNAJCCJGOK(this IncrementalHash COEHPKCLNDD, short EACLPEOIJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7D8DC50", Offset = "0x7D8C850", VA = "0x187D8DC50")]
	public static void ONANKKJECCN(this IncrementalHash COEHPKCLNDD, byte ACCGGFABFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D130", Offset = "0x7D8BD30", VA = "0x187D8D130")]
	public static void BJNGCALGGEN(this IncrementalHash COEHPKCLNDD, bool DIIEGJDKOMJ, bool PCPOFCHBANE = false, bool KDMDOGPAGEA = false, bool OIOEBHPFLMC = false, bool GBEBKILJGPC = false, bool JGBILKLPDEH = false, bool NJOJBNIDHAP = false, bool MLNBIHKHJHK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CEB0", Offset = "0x3C7BAB0", VA = "0x183C7CEB0")]
	public static void HDKJPKKGBLI<T>(this IncrementalHash COEHPKCLNDD, T NBOMHMDCNPE) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D530", Offset = "0x7D8C130", VA = "0x187D8D530")]
	public static void GODDIKAOJOK(this IncrementalHash COEHPKCLNDD, float HBPPIJLHCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D760", Offset = "0x7D8C360", VA = "0x187D8D760")]
	public static void KIOCNGLMBLJ(this IncrementalHash COEHPKCLNDD, ulong ECNJDFILNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D2A0", Offset = "0x7D8BEA0", VA = "0x187D8D2A0")]
	public static void ECIAOFKEDCP(this IncrementalHash COEHPKCLNDD, uint BBAFHOJOPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D4D0", Offset = "0x7D8C0D0", VA = "0x187D8D4D0")]
	public static void GCEGNKHIJDL(this IncrementalHash COEHPKCLNDD, ushort BADGCCPPCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7D8D000", Offset = "0x7D8BC00", VA = "0x187D8D000")]
	public static void AEPAGCFMBHO(this IncrementalHash COEHPKCLNDD, Vector3 CLFHNGKKCAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BNEGJCIMBAK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7D8B4B0", Offset = "0x7D8A0B0", VA = "0x187D8B4B0")]
	public BNEGJCIMBAK(string FNFIPKNHEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class IKHBIBBCKIG
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void BAMPHEILOIP(ushort GOFBHJJILIM, ushort GHNCGICDENH, ushort JANEBGLOAPM, ushort APMOMAFOMJA);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void CGIDNJBFFCB(ushort NKBLPKLAEPD, ushort EMIEDEHFHFH);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void GANMJPGBACL();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort BNMOCDBPGHM = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	protected IKHBIBBCKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class NPBBHDMPIGH<T> : IKHBIBBCKIG where T : NPBBHDMPIGH<T>.OJPMHHFBGMI
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface OJPMHHFBGMI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		CGIDNJBFFCB AMOLEBKLLDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		CGIDNJBFFCB PCNLKNIOHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		GANMJPGBACL HJEJIAOBBJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> MBKJKOKFPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private GANMJPGBACL CENEJEPBCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GANMJPGBACL CIODBMIOMGD;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool MHDDLKGFBPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6B040", Offset = "0xA69C40", VA = "0x180A6B040")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB30", Offset = "0xA1D730", VA = "0x180A1EB30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort JBBMJPCICAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x113F1F0", Offset = "0x113DDF0", VA = "0x18113F1F0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x113F200", Offset = "0x113DE00", VA = "0x18113F200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort FDDLCGNKDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x554F090", Offset = "0x554DC90", VA = "0x18554F090")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x554F070", Offset = "0x554DC70", VA = "0x18554F070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort CGEDBKPPKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xE6E510", Offset = "0xE6D110", VA = "0x180E6E510")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xE6E620", Offset = "0xE6D220", VA = "0x180E6E620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort GHHNPLJFMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x554F160", Offset = "0x554DD60", VA = "0x18554F160")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x554EF10", Offset = "0x554DB10", VA = "0x18554EF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool HHFLJEEEDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x113F1E0", Offset = "0x113DDE0", VA = "0x18113F1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool OHJBIJFAOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xF63570", Offset = "0xF62170", VA = "0x180F63570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event BAMPHEILOIP EEPPLBNEDDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x554EFD0", Offset = "0x554DBD0", VA = "0x18554EFD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x554EF30", Offset = "0x554DB30", VA = "0x18554EF30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x554F0D0", Offset = "0x554DCD0", VA = "0x18554F0D0")]
	private T HOCMBMEONJL(ushort LCJMDKKNDNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x554F180", Offset = "0x554DD80", VA = "0x18554F180")]
	private T LLNLCHMJDEJ(ushort LCJMDKKNDNK, ushort COLJPHCLBIC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x554F440", Offset = "0x554E040", VA = "0x18554F440")]
	protected T LNNOPDMBDJE(uint EABOLJHFOCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x554FD00", Offset = "0x554E900", VA = "0x18554FD00")]
	protected NPBBHDMPIGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x554F480", Offset = "0x554E080", VA = "0x18554F480")]
	public void NCDPMFEBAFP(ushort FAOEIOCKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x554F560", Offset = "0x554E160", VA = "0x18554F560")]
	public void NCDPMFEBAFP(ushort FAOEIOCKLAH, ushort CLBJBNLMMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x554F4A0", Offset = "0x554E0A0", VA = "0x18554F4A0", Slot = "4")]
	protected virtual void NCDPMFEBAFP(uint NOODJIGKEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x554F5B0", Offset = "0x554E1B0", VA = "0x18554F5B0")]
	protected void NPKFPFIPNMC(uint NOODJIGKEBB, uint AOILDKPOAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x554FC90", Offset = "0x554E890", VA = "0x18554FC90")]
	protected void PGNFBOPECAM(ushort LCJMDKKNDNK, ushort COLJPHCLBIC, T DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x554F0A0", Offset = "0x554DCA0", VA = "0x18554F0A0")]
	private void FKHOKPPKJKD(uint EABOLJHFOCN, T DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x554F210", Offset = "0x554DE10", VA = "0x18554F210")]
	protected void LMLAGLMCMAH(float DJGAODFCDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x554F170", Offset = "0x554DD70", VA = "0x18554F170")]
	protected uint LHJKIJFPBBE(ushort LCJMDKKNDNK, ushort COLJPHCLBIC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x554F080", Offset = "0x554DC80", VA = "0x18554F080")]
	protected ushort EBCILHFKBFH(uint NFCMMLGJKNM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x554EF20", Offset = "0x554DB20", VA = "0x18554EF20")]
	protected ushort AMPOAHPBIPO(uint NFCMMLGJKNM)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class JFFHICAFAJL : NPBBHDMPIGH<JFFHICAFAJL.COJNGHJCIBM>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class COJNGHJCIBM : OJPMHHFBGMI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public CGIDNJBFFCB AMOLEBKLLDF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public CGIDNJBFFCB PCNLKNIOHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public GANMJPGBACL HJEJIAOBBJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public COJNGHJCIBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C2F0", Offset = "0x7D8AEF0", VA = "0x187D8C2F0")]
	public void ENBNCIDGFKI(ushort EIJBNMHGBAF, CGIDNJBFFCB FHCIPGPOHPA, CGIDNJBFFCB KJAGIOONKCP, GANMJPGBACL GKAPPLGLEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C210", Offset = "0x7D8AE10", VA = "0x187D8C210")]
	public void ENBNCIDGFKI(ushort LCJMDKKNDNK, ushort COLJPHCLBIC, CGIDNJBFFCB FHCIPGPOHPA, CGIDNJBFFCB KJAGIOONKCP, GANMJPGBACL GKAPPLGLEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C3D0", Offset = "0x7D8AFD0", VA = "0x187D8C3D0")]
	public void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C090", Offset = "0x7D8AC90", VA = "0x187D8C090")]
	protected JFFHICAFAJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IFDHKIAMFBD : JFFHICAFAJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool IIPMKDBFOJL;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xCBAD70", Offset = "0xCB9970", VA = "0x180CBAD70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xDAFB70", Offset = "0xDAE770", VA = "0x180DAFB70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D8BFD0", Offset = "0x7D8ABD0", VA = "0x187D8BFD0")]
	public void LEIJOMGLGOC(ushort CMBGCPOKKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C030", Offset = "0x7D8AC30", VA = "0x187D8C030")]
	public void LEIJOMGLGOC(ushort CMBGCPOKKFP, ushort DMKMLCOPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D8C090", Offset = "0x7D8AC90", VA = "0x187D8C090")]
	public IFDHKIAMFBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class FEPOAEHGNLL<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class ECEANEKKJIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode LAAPKLDJLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode LIPFJJEAFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HNGPOBPAIGC IJNCJOKBAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<HNGPOBPAIGC> OFHDIKDNKMK;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ECEANEKKJIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct HNGPOBPAIGC : IComparable<HNGPOBPAIGC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int NBHPMDIDLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant CJNMKEOGLHK;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x17BE2E0", Offset = "0x17BCEE0", VA = "0x1817BE2E0")]
		public HNGPOBPAIGC(int NBHPMDIDLEB, TClaimant CJNMKEOGLHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8EC0", Offset = "0x4DB7AC0", VA = "0x184DB8EC0")]
		public bool OEENHEANLMI([In] HNGPOBPAIGC GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8EB0", Offset = "0x4DB7AB0", VA = "0x184DB8EB0")]
		public bool GFFBGLKOLFN([In] HNGPOBPAIGC GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8EA0", Offset = "0x4DB7AA0", VA = "0x184DB8EA0", Slot = "4")]
		public int CompareTo(HNGPOBPAIGC GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4DB8F20", Offset = "0x4DB7B20", VA = "0x184DB8F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum GMLPBKFPPOF
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class LEDLOFKJOMC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public FEPOAEHGNLL<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public LEDLOFKJOMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5284020", Offset = "0x5282C20", VA = "0x185284020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x52841E0", Offset = "0x5282DE0", VA = "0x1852841E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5284100", Offset = "0x5282D00", VA = "0x185284100", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A6D0", Offset = "0x4C992D0", VA = "0x184C9A6D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly DJJGMNBJIKA<ECEANEKKJIH> AMNILEPAIOJ;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly DJJGMNBJIKA<List<HNGPOBPAIGC>> ABIEIEMNBFH;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int CLHFIIMJCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> LECKKDADEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, ECEANEKKJIH> FIHKMLANELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private GMLPBKFPPOF KEGLMDPKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GPBMOMKFEAK(TNode PBOIPJOJPLG);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JJBPDDFNDAE(TNode PBOIPJOJPLG, TClaimant AHMPAPKGDDP, TClaimant JLGIPHCIBOE);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4C09970", Offset = "0x4C08570", VA = "0x184C09970")]
	public FEPOAEHGNLL(GMLPBKFPPOF KEGLMDPKKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4C095E0", Offset = "0x4C081E0", VA = "0x184C095E0")]
	public void MNIKDBELOKC(TNode PBOIPJOJPLG, TNode JHPFPLHIKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4C08BC0", Offset = "0x4C077C0", VA = "0x184C08BC0")]
	public void GCIDMJAHHJC(TClaimant CJNMKEOGLHK, TNode DDINGLDKFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4C086D0", Offset = "0x4C072D0", VA = "0x184C086D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4C09540", Offset = "0x4C08140", VA = "0x184C09540")]
	private void MNGHEPCOLNB(TClaimant CJNMKEOGLHK, TNode FFENKGCNENJ, TNode DDINGLDKFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4C094D0", Offset = "0x4C080D0", VA = "0x184C094D0")]
	private int MJOKIGLBIPJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4C08330", Offset = "0x4C06F30", VA = "0x184C08330")]
	private void CCLFHOCJODB(TClaimant CJNMKEOGLHK, TNode MCJGBDHFJHF, TNode BMMHMAPMBII, int HNEPIHKHPNN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4C08650", Offset = "0x4C07250", VA = "0x184C08650")]
	private void CPCHECNFIHI(HNGPOBPAIGC MIBKJHAAGMA, ECEANEKKJIH GAPFGOJCKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4C09210", Offset = "0x4C07E10", VA = "0x184C09210")]
	private void MDLLFGKHFBI(TClaimant CJNMKEOGLHK, TNode MCJGBDHFJHF, TNode BMMHMAPMBII, int HNEPIHKHPNN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4C09030", Offset = "0x4C07C30", VA = "0x184C09030")]
	private void IAMNBOJMFBG(HNGPOBPAIGC MIBKJHAAGMA, TNode PBOIPJOJPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4C08250", Offset = "0x4C06E50", VA = "0x184C08250")]
	private void AEOCDPCLNAD(HNGPOBPAIGC MIBKJHAAGMA, ECEANEKKJIH GAPFGOJCKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4C08E30", Offset = "0x4C07A30", VA = "0x184C08E30")]
	private void HCFNKGOFAIB(ECEANEKKJIH GAPFGOJCKND, bool MCPNLNPFJMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4C08870", Offset = "0x4C07470", VA = "0x184C08870")]
	private void EALHEALNIMF(ECEANEKKJIH GAPFGOJCKND, TNode JHPFPLHIKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4C09140", Offset = "0x4C07D40", VA = "0x184C09140")]
	[IteratorStateMachine(typeof(FEPOAEHGNLL<, >.LEDLOFKJOMC))]
	private IEnumerable<TNode> LFDJLGMGAHI(TNode MCJGBDHFJHF, TNode BMMHMAPMBII, bool AGNINOFLBJJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4C08F50", Offset = "0x4C07B50", VA = "0x184C08F50")]
	private ECEANEKKJIH HLLPEPINODB(TNode PBOIPJOJPLG, TNode LIPFJJEAFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4C08CE0", Offset = "0x4C078E0", VA = "0x184C08CE0")]
	private ECEANEKKJIH HAMEAANIJNO(TNode PBOIPJOJPLG, TNode LIPFJJEAFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4C09670", Offset = "0x4C08270", VA = "0x184C09670")]
	private void PCMAMICPGAC(ECEANEKKJIH GAPFGOJCKND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JJKOBPAHFMF<T> : IEnumerable<JJKOBPAHFMF<T>.GCEPKKDFIIG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct GCEPKKDFIIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T OOHGFGHCOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int EMMACFPOKFB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class IJKOHNILOOK : IEnumerator<GCEPKKDFIIG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private JJKOBPAHFMF<T> IGFGOFBOBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int EMMACFPOKFB;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4757260", Offset = "0x4755E60", VA = "0x184757260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public GCEPKKDFIIG FGILBCMPPDP
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4E7D200", Offset = "0x4E7BE00", VA = "0x184E7D200", Slot = "4")]
			get
			{
				return default(GCEPKKDFIIG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D110", Offset = "0x4E7BD10", VA = "0x184E7D110")]
		public IJKOHNILOOK(JJKOBPAHFMF<T> IGFGOFBOBHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4E7D090", Offset = "0x4E7BC90", VA = "0x184E7D090", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x47B9CB0", Offset = "0x47B88B0", VA = "0x1847B9CB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x11FF100", Offset = "0x11FDD00", VA = "0x1811FF100", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct BGBEKNDGPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool IFEENLNANJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T OOHGFGHCOAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int JHFELMPBJOI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> MKEECOIDKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private BGBEKNDGPFO[] NKMIAAHONNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int MDPJLOOPGEG;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int MMPBIANDCOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xBDFF80", Offset = "0xBDEB80", VA = "0x180BDFF80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xF7D730", Offset = "0xF7C330", VA = "0x180F7D730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x428CDB0", Offset = "0x428B9B0", VA = "0x18428CDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5100440", Offset = "0x50FF040", VA = "0x185100440")]
	public JJKOBPAHFMF(int PDJAEHLNOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x51008D0", Offset = "0x50FF4D0", VA = "0x1851008D0")]
	public JJKOBPAHFMF(GCEPKKDFIIG[] FJKIOFJCMHI, bool LIHKGJFAMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x50FF780", Offset = "0x50FE380", VA = "0x1850FF780")]
	public int APBBNMFOJKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x50FFAF0", Offset = "0x50FE6F0", VA = "0x1850FFAF0")]
	private int NCDLALOIENG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x50FF830", Offset = "0x50FE430", VA = "0x1850FF830", Slot = "6")]
	protected virtual uint DCMOHFPMDID(uint COEHPKCLNDD, T OOHGFGHCOAJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x50FFDF0", Offset = "0x50FE9F0", VA = "0x1850FFDF0")]
	public bool ODDOMNHALCL(T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x50FFCE0", Offset = "0x50FE8E0", VA = "0x1850FFCE0")]
	public int NNIHMNLPNJA(T OOHGFGHCOAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x50FF8A0", Offset = "0x50FE4A0", VA = "0x1850FF8A0")]
	public T EMBLLFFHGFA(int EMMACFPOKFB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x50FFE40", Offset = "0x50FEA40", VA = "0x1850FFE40")]
	public bool OFIPOAPPKAI(T OOHGFGHCOAJ, bool IAJHCCEBJEA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5100120", Offset = "0x50FED20", VA = "0x185100120")]
	public bool OFIPOAPPKAI(T OOHGFGHCOAJ, int EMMACFPOKFB, bool IAJHCCEBJEA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5100320", Offset = "0x50FEF20", VA = "0x185100320")]
	private int PCKELNLPPCL(int DPCFFPEBOPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x51003C0", Offset = "0x50FEFC0", VA = "0x1851003C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x51003C0", Offset = "0x50FEFC0", VA = "0x1851003C0", Slot = "4")]
	private IEnumerator<GCEPKKDFIIG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DJJGMNBJIKA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> CDMBMKNDFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> JMBPOBGNDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int ILBNKKLGNKD;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x42A7F70", Offset = "0x42A6B70", VA = "0x1842A7F70")]
	public static DJJGMNBJIKA<T> BEGEKDGJBOH(int PDJAEHLNOAH = 0, int ILBNKKLGNKD = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x42A85D0", Offset = "0x42A71D0", VA = "0x1842A85D0")]
	public static DJJGMNBJIKA<T> KCDDBCMBNDA(int PDJAEHLNOAH = 0, int ILBNKKLGNKD = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x42A8780", Offset = "0x42A7380", VA = "0x1842A8780")]
	public DJJGMNBJIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x42A87B0", Offset = "0x42A73B0", VA = "0x1842A87B0")]
	public DJJGMNBJIKA(int PDJAEHLNOAH, int ILBNKKLGNKD = int.MaxValue, bool FEDNLFOGAMN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x42A8450", Offset = "0x42A7050", VA = "0x1842A8450")]
	public T JOCLKIICIAK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x42A8380", Offset = "0x42A6F80", VA = "0x1842A8380")]
	public void FLLBKAADJOO(T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x42A86B0", Offset = "0x42A72B0", VA = "0x1842A86B0")]
	private void LOPMNIEABKO(T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x42A7F50", Offset = "0x42A6B50", VA = "0x1842A7F50")]
	private void AKMOGPCBMLP(T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x42A8240", Offset = "0x42A6E40", VA = "0x1842A8240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x42A8050", Offset = "0x42A6C50", VA = "0x1842A8050")]
	private void DKJIKPJFCFI(IEnumerable<T> AIPJHMCGMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LBDFBIAIMKJ<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> NJHNNBNFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T EBAHNALLGBE;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T IHLGHJLKIJG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA21F20", Offset = "0xA20B20", VA = "0x180A21F20", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x527CB30", Offset = "0x527B730", VA = "0x18527CB30")]
	public bool BIOPACEHAJG(T OOHGFGHCOAJ, int NBHPMDIDLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x42D34E0", Offset = "0x42D20E0", VA = "0x1842D34E0")]
	public bool HELGMGPDIFN(int NBHPMDIDLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x527CEE0", Offset = "0x527BAE0", VA = "0x18527CEE0")]
	public T PMLAHODJPMF(int IEMGHJAJNJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x527CC80", Offset = "0x527B880", VA = "0x18527CC80")]
	private bool CHDBAODMJFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x527CEA0", Offset = "0x527BAA0", VA = "0x18527CEA0")]
	public bool GFPOIIGIKGC(int NBHPMDIDLEB, [Out] T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x506E830", Offset = "0x506D430", VA = "0x18506E830")]
	public LBDFBIAIMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class KPCEGFGCHKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct CLFEJGMCAFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T IOOEMCNJEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int FGIMOFHDCCK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<CLFEJGMCAFL> CAPOGHJBIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T DMNPEBDNKON;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x428CDB0", Offset = "0x428B9B0", VA = "0x18428CDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5205700", Offset = "0x5204300", VA = "0x185205700")]
	public bool FHKFJOGHNEN(T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5206120", Offset = "0x5204D20", VA = "0x185206120")]
	public void NKAMMCABBBC(T OOHGFGHCOAJ, int NBHPMDIDLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5205940", Offset = "0x5204540", VA = "0x185205940")]
	public bool HMCNGGMNMHK(T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5205F10", Offset = "0x5204B10", VA = "0x185205F10")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5205F70", Offset = "0x5204B70", VA = "0x185205F70")]
	public T MFPJPHHIJJC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5205C20", Offset = "0x5204820", VA = "0x185205C20")]
	protected void ILJHJECGBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5206190", Offset = "0x5204D90", VA = "0x185206190")]
	public KPCEGFGCHKE()
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
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E2D0", Offset = "0x7D8CED0", VA = "0x187D8E2D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E5A0", Offset = "0x7D8D1A0", VA = "0x187D8E5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E4B0", Offset = "0x7D8D0B0", VA = "0x187D8E4B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E220", Offset = "0x7D8CE20", VA = "0x187D8E220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E4F0", Offset = "0x7D8D0F0", VA = "0x187D8E4F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E400", Offset = "0x7D8D000", VA = "0x187D8E400")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7D8E1A0", Offset = "0x7D8CDA0", VA = "0x187D8E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x59C3F30", Offset = "0x59C2B30", VA = "0x1859C3F30", Slot = "4")]
		public virtual T IKKGELGPIII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface MNKGMDDJLCF
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache HCIGOPFNBHL
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
		public struct EKMMCPDBADF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> DNNGKIFFAHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool KABGFNMEMKH;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x193B530", Offset = "0x193A130", VA = "0x18193B530")]
			public EKMMCPDBADF(List<Component> DNNGKIFFAHG, bool KABGFNMEMKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x4738DB0", Offset = "0x47379B0", VA = "0x184738DB0")]
			public LDBEKIPGPLE<T> MEEEBEDBKAB()
			{
				return default(LDBEKIPGPLE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x4738E10", Offset = "0x4737A10", VA = "0x184738E10", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x4738E10", Offset = "0x4737A10", VA = "0x184738E10", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct LDBEKIPGPLE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> DNNGKIFFAHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool KABGFNMEMKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int EMMACFPOKFB;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T FGILBCMPPDP
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x52822C0", Offset = "0x5280EC0", VA = "0x1852822C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x5282250", Offset = "0x5280E50", VA = "0x185282250", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x5282290", Offset = "0x5280E90", VA = "0x185282290")]
			public LDBEKIPGPLE(List<Component> DNNGKIFFAHG, bool KABGFNMEMKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x5282190", Offset = "0x5280D90", VA = "0x185282190", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x52821A0", Offset = "0x5280DA0", VA = "0x1852821A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x47A8110", Offset = "0x47A6D10", VA = "0x1847A8110", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7D8FF90", Offset = "0x7D8EB90", VA = "0x187D8FF90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7D8FA00", Offset = "0x7D8E600", VA = "0x187D8FA00")]
		private void LEIJOMGLGOC(GameObject CJBDGNIBOEE, bool JMDCPKFBLOI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F970", Offset = "0x7D8E570", VA = "0x187D8F970")]
		public static void LEIJOMGLGOC(GameObject CJBDGNIBOEE, ToolHierarchyCache AFHEFLCAFIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7D8FEF0", Offset = "0x7D8EAF0", VA = "0x187D8FEF0")]
		public void PPGCGLMIMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3E3D560", Offset = "0x3E3C160", VA = "0x183E3D560")]
		public void DBHBLPKCNDL<T>(Action<T> IFDCDCHOGGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3E3D780", Offset = "0x3E3C380", VA = "0x183E3D780")]
		public T NJLCPPGPNHC<T>(bool KABGFNMEMKH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3E3D7F0", Offset = "0x3E3C3F0", VA = "0x183E3D7F0")]
		public EKMMCPDBADF<T> PMEOLKGMNFF<T>(bool KABGFNMEMKH = false) where T : class
		{
			return default(EKMMCPDBADF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7D8FB70", Offset = "0x7D8E770", VA = "0x187D8FB70")]
		public List<Component> MKKHPFNFJAP(Type OPOPAMPKKGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F880", Offset = "0x7D8E480", VA = "0x187D8F880", Slot = "4")]
		public bool Equals(ToolHierarchyCache KFGAJBKADFK, ToolHierarchyCache FEABMDLFEMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7D8F900", Offset = "0x7D8E500", VA = "0x187D8F900", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KDKJDFFGNJJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class AOGIADCAGFO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int PDJAEHLNOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int APLMJPLKAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> IDAGLLCCAJB;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4739070", Offset = "0x4737C70", VA = "0x184739070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T FOKPOJPOLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5070580", Offset = "0x506F180", VA = "0x185070580")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T OFDJFPDMJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5070970", Offset = "0x506F570", VA = "0x185070970")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T AOCDBLNALFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5070420", Offset = "0x506F020", VA = "0x185070420")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5070A00", Offset = "0x506F600", VA = "0x185070A00")]
	public AOGIADCAGFO(int PDJAEHLNOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5070740", Offset = "0x506F340", VA = "0x185070740")]
	public void NKAMMCABBBC(T KJPLHJNFFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x50706F0", Offset = "0x506F2F0", VA = "0x1850706F0")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5070310", Offset = "0x506EF10", VA = "0x185070310")]
	public void CKAPPGPOJPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x50703D0", Offset = "0x506EFD0", VA = "0x1850703D0")]
	public void DCPIIODIDMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5070730", Offset = "0x506F330", VA = "0x185070730")]
	public void MMFAOCKDFDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5070500", Offset = "0x506F100", VA = "0x185070500")]
	public List<T> GNCPBECONBH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class IJAJCKGOONC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct BPBMIJPGGKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int FGIMOFHDCCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T IOOEMCNJEAH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, BPBMIJPGGKP> NJHNNBNFCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> KGEDPIKGNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T EBAHNALLGBE;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T IHLGHJLKIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xDD35D0", Offset = "0xDD21D0", VA = "0x180DD35D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x4E7B690", Offset = "0x4E7A290", VA = "0x184E7B690", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool MMGKOLPFCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x4E7B6C0", Offset = "0x4E7A2C0", VA = "0x184E7B6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object EFKONEHOGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA217E0", Offset = "0xA203E0", VA = "0x180A217E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4E78130", Offset = "0x4E76D30", VA = "0x184E78130")]
	public bool BIOPACEHAJG(T OOHGFGHCOAJ, object HEDGIMBCGHA, int NBHPMDIDLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4E7B570", Offset = "0x4E7A170", VA = "0x184E7B570")]
	public bool HELGMGPDIFN(object HEDGIMBCGHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4E7B1F0", Offset = "0x4E79DF0", VA = "0x184E7B1F0")]
	public bool GFPOIIGIKGC(object HEDGIMBCGHA, [Out] T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4E7B5F0", Offset = "0x4E7A1F0", VA = "0x184E7B5F0")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4E798B0", Offset = "0x4E784B0", VA = "0x184E798B0")]
	private bool CHDBAODMJFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4E7B710", Offset = "0x4E7A310", VA = "0x184E7B710")]
	public IJAJCKGOONC()
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
