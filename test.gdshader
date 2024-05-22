shader_type spatial;

uniform float travel_speed = 10.0;
uniform float distance = 0.5;

void fragment() {
	vec3 color;
	ALPHA = 0.2;
	EMISSION = vec3(0,0,0);
	color = vec3(0.0,0.0,1.0);
	if (UV.y > sin(TIME * travel_speed + UV.y * (travel_speed)) && UV.y < sin(TIME * travel_speed + UV.y * (travel_speed + distance))) {
		ALPHA = 1.0;
		EMISSION = vec3(0.5,0.5,0.6);
		color = vec3(1.0,1.0,1.2);
	}

	ALBEDO = color;
}

void light() {

}
