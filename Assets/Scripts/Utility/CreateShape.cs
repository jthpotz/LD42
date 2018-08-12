using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Colors = Constants.Colors;

public class CreateShape : MonoBehaviour {

	public Colors[] colorList = new Colors[6];



	public int[] s11 = new int[3];
	public int[] s12 = new int[3];
	public int[] s13 = new int[3];
	public int[] s14 = new int[3];
	public int[] s15 = new int[3];
	public int[] s16 = new int[3];

	public int size1 = 0;

	public int[] s21 = new int[3];
	public int[] s22 = new int[3];
	public int[] s23 = new int[3];
	public int[] s24 = new int[3];
	public int[] s25 = new int[3];
	public int[] s26 = new int[3];

	public int size2 = 0;

	public int[] s31 = new int[3];
	public int[] s32 = new int[3];
	public int[] s33 = new int[3];
	public int[] s34 = new int[3];
	public int[] s35 = new int[3];
	public int[] s36 = new int[3];

	public int size3 = 0;

	public int[] s41 = new int[3];
	public int[] s42 = new int[3];
	public int[] s43 = new int[3];
	public int[] s44 = new int[3];
	public int[] s45 = new int[3];
	public int[] s46 = new int[3];

	public int size4 = 10;

	public int[] s51 = new int[3];
	public int[] s52 = new int[3];
	public int[] s53 = new int[3];
	public int[] s54 = new int[3];
	public int[] s55 = new int[3];
	public int[] s56 = new int[3];

	public int size5 = 0;

	public int[] s61 = new int[3];
	public int[] s62 = new int[3];
	public int[] s63 = new int[3];
	public int[] s64 = new int[3];
	public int[] s65 = new int[3];
	public int[] s66 = new int[3];

	public int size6 = 0;

	public void Start(){
		GenerateShape ();
	}

	public void Update(){
		
	}

	public void GenerateShape(){

		Generate1st ();
		Generate2nd ();
		Generate3rd ();
		Generate4th ();
		Generate5th ();
		Generate6th ();

	}

	private void Generate1st(){
		GameObject go;
		Object obj = SelectPrefab.SolidHex (colorList [0]);
		if (size1 > 0) {
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s11 [0], s11 [1], s11 [2]), Quaternion.identity) as GameObject;
			go.name = "1-1";
		}
		else {
			return;
		}
		if (size1 > 1){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s12 [0], s12 [1], s12 [2]), Quaternion.identity) as GameObject;
			go.name = "1-2";
		}
		else {
			return;
		}
		if (size1 > 2){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s13 [0], s13 [1], s13 [2]), Quaternion.identity) as GameObject;
			go.name = "1-3";
		}
		else {
			return;
		}
		if (size1 > 3){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s14 [0], s14 [1], s14 [2]), Quaternion.identity) as GameObject;
			go.name = "1-4";
		}
		else {
			return;
		}
		if (size1 > 4){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s15 [0], s15 [1], s15 [2]), Quaternion.identity) as GameObject;
			go.name = "1-5";
		}
		else {
			return;
		}
		if (size1 > 5){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s16 [0], s16 [1], s16 [2]), Quaternion.identity) as GameObject;
			go.name = "1-5";
		}
		else {
			return;
		}
	}

	private void Generate2nd(){
		GameObject go;
		Object obj = SelectPrefab.SolidHex (colorList [1]);
		if (size2 > 0) {
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s21 [0], s21 [1], s21 [2]), Quaternion.identity) as GameObject;
			go.name = "2-1";
		}
		else {
			return;
		}
		if (size2 > 1){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s22 [0], s22 [1], s22 [2]), Quaternion.identity) as GameObject;
			go.name = "2-2";
		}
		else {
			return;
		}
		if (size2 > 2){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s23 [0], s23 [1], s23 [2]), Quaternion.identity) as GameObject;
			go.name = "2-3";
		}
		else {
			return;
		}
		if (size2 > 3){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s24 [0], s24 [1], s24 [2]), Quaternion.identity) as GameObject;
			go.name = "2-4";
		}
		else {
			return;
		}
		if (size2 > 4){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s25 [0], s25 [1], s25 [2]), Quaternion.identity) as GameObject;
			go.name = "2-5";
		}
		else {
			return;
		}
		if (size2 > 5){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s26 [0], s26 [1], s26 [2]), Quaternion.identity) as GameObject;
			go.name = "2-6";
		}
		else {
			return;
		}
	}

	private void Generate3rd(){
		GameObject go;
		Object obj = SelectPrefab.SolidHex (colorList [2]);
		if (size3 > 0) {
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s31 [0], s31 [1], s31 [2]), Quaternion.identity) as GameObject;
			go.name = "3-1";
		}
		else {
			return;
		}
		if (size3 > 1){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s32 [0], s32 [1], s32 [2]), Quaternion.identity) as GameObject;
			go.name = "3-2";
		}
		else {
			return;
		}
		if (size3 > 2){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s33 [0], s33 [1], s33 [2]), Quaternion.identity) as GameObject;
			go.name = "3-3";
		}
		else {
			return;
		}
		if (size3 > 3){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s34 [0], s34 [1], s34 [2]), Quaternion.identity) as GameObject;
			go.name = "3-4";
		}
		else {
			return;
		}
		if (size3 > 4){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s35 [0], s35 [1], s35 [2]), Quaternion.identity) as GameObject;
			go.name = "3-5";
		}
		else {
			return;
		}
		if (size3 > 5){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s36 [0], s36 [1], s36 [2]), Quaternion.identity) as GameObject;
			go.name = "3-6";
		}
		else {
			return;
		}
	}

	private void Generate4th(){
		GameObject go;
		Object obj = SelectPrefab.SolidHex (colorList [3]);
		if (size4 > 0) {
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s41 [0], s41 [1], s41 [2]), Quaternion.identity) as GameObject;
			go.name = "4-1";
		}
		else {
			return;
		}
		if (size4 > 1){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s42 [0], s42 [1], s42 [2]), Quaternion.identity) as GameObject;
			go.name = "4-2";
		}
		else {
			return;
		}
		if (size4 > 2){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s43 [0], s43 [1], s43 [2]), Quaternion.identity) as GameObject;
			go.name = "4-3";
		}
		else {
			return;
		}
		if (size4 > 3){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s44 [0], s44 [1], s44 [2]), Quaternion.identity) as GameObject;
			go.name = "4-4";
		}
		else {
			return;
		}
		if (size4 > 4){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s45 [0], s45 [1], s45 [2]), Quaternion.identity) as GameObject;
			go.name = "4-5";
		}
		else {
			return;
		}
		if (size4 > 5){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s46 [0], s46 [1], s46 [2]), Quaternion.identity) as GameObject;
			go.name = "4-6";
		}
		else {
			return;
		}
	}

	private void Generate5th(){
		GameObject go;
		Object obj = SelectPrefab.SolidHex (colorList [4]);
		if (size5 > 0) {
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s51 [0], s51 [1], s51 [2]), Quaternion.identity) as GameObject;
			go.name = "5-1";
		}
		else {
			return;
		}
		if (size5 > 1){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s52 [0], s52 [1], s52 [2]), Quaternion.identity) as GameObject;
			go.name = "5-2";
		}
		else {
			return;
		}
		if (size5 > 2){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s53 [0], s53 [1], s53 [2]), Quaternion.identity) as GameObject;
			go.name = "5-3";
		}
		else {
			return;
		}
		if (size5 > 3){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s54 [0], s54 [1], s54 [2]), Quaternion.identity) as GameObject;
			go.name = "5-4";
		}
		else {
			return;
		}
		if (size5 > 4){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s55 [0], s55 [1], s55 [2]), Quaternion.identity) as GameObject;
			go.name = "5-5";
		}
		else {
			return;
		}
		if (size5 > 5){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s56 [0], s56 [1], s56 [2]), Quaternion.identity) as GameObject;
			go.name = "5-6";
		}
		else {
			return;
		}
	}

	private void Generate6th(){
		GameObject go;
		Object obj = SelectPrefab.SolidHex (colorList [5]);
		if (size6 > 0) {
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s61 [0], s61 [1], s61 [2]), Quaternion.identity) as GameObject;
			go.name = "6-1";
		}
		else {
			return;
		}
		if (size6 > 1){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s62 [0], s62 [1], s62 [2]), Quaternion.identity) as GameObject;
			go.name = "6-2";
		}
		else {
			return;
		}
		if (size6 > 2){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s63 [0], s63 [1], s63 [2]), Quaternion.identity) as GameObject;
			go.name = "6-3";
		}
		else {
			return;
		}
		if (size6 > 3){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s64 [0], s64 [1], s64 [2]), Quaternion.identity) as GameObject;
			go.name = "6-4";
		}
		else {
			return;
		}
		if (size6 > 4){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s65 [0], s65 [1], s65 [2]), Quaternion.identity) as GameObject;
			go.name = "6-5";
		}
		else {
			return;
		}
		if (size6 > 5){
			go = GameObject.Instantiate (obj, CoordinateConversions.CubeToSquare (s66 [0], s66 [1], s66 [2]), Quaternion.identity) as GameObject;
			go.name = "6-6";
		}
		else {
			return;
		}
	}
		

}
